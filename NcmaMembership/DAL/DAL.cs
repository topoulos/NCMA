using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Data.SqlClient;
using System.Data;

namespace NcmaMembership.DAL
{
    public static class DAL
    {
        readonly static System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/");
        readonly static System.Configuration.ConnectionStringSettings connString = rootWebConfig.ConnectionStrings.ConnectionStrings["LocalSqlServer"];
        static SqlConnection conn = new SqlConnection(connString.ToString());

        public static List<InsertRecord> ConvertToParameters<T>(T myObject)
        {
            
            List<InsertRecord> recs = new List<InsertRecord>();
            
            List<FieldInfo> fields = myObject.GetType().GetFields().ToList<FieldInfo>();

            foreach (var field in fields)
            {
                InsertRecord rec = new InsertRecord();
                var property = myObject.GetType().GetProperty(field.Name);
                var value = property.GetValue(myObject, null);
                rec.fieldName = field.Name;
                rec.fieldValue = value;
                recs.Add(rec);

            }

            return recs;
        }



        private static object getValue<TModel>(TModel item, string propertyName) where TModel : class
        {
            PropertyInfo p = typeof(TModel).GetProperty(propertyName);
            return p.GetValue(item, null);
        }

        public  static string GetQueryFilter(List<string> fields, string condition, string textToFind)
        {
            string wildCard = condition == "Begins With" ? "{0}%" : "%{0}%";
            string expression = string.Empty;
            string quote = "'";
            foreach (string str in fields)
            {
                expression += String.Format("{0} LIKE {1}{2}{1} OR ", str, quote, string.Format(wildCard, textToFind));

            }
            //trim last OR

            expression = expression.Substring(1, expression.Length - 3);

            return expression;
        }

        public static  bool InsertRecordIntoTable(Object o, string idName, string sprocName)
        {
            List<InsertRecord> recs = ConvertToParameters(o);

            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sprocName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (InsertRecord rec in recs)
                    {
                        if (rec.fieldName.ToLower() != idName.ToLower()) //leave off ID
                            cmd.Parameters.Add(new SqlParameter(rec.fieldName, rec.fieldValue));
                    }
                    int numRows = cmd.ExecuteNonQuery();
                    return numRows == 1;


                }
            }

        }
        public static bool DeleteRecordFromTableWithID(int id, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(String.Format("DELETE from {0} WHERE ID = @ID", tableName), conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    int numRows = cmd.ExecuteNonQuery();
                    return numRows == 1;


                }
            }

        }

    
        public static DataTable GetRecordFromTableByID(int id, string tableName)
        {

            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(String.Format("Select * from {0} WHERE ID = @ID", tableName), conn))
                {

                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Load(rdr);
                        return tbl;
                    }
                }


            }
        }

        

        
        public static bool UpdateRecordInTable(Object o, string idName, string sprocName)
        {

            List<InsertRecord> recs = ConvertToParameters(o);

            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sprocName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (InsertRecord rec in recs)
                    {
                        cmd.Parameters.Add(new SqlParameter(rec.fieldName, rec.fieldValue));
                    }
                    int numRows = cmd.ExecuteNonQuery();
                    return numRows == 1;


                }
            }

        }

        public static DataTable GetAllRecordsFromTable(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(String.Format("Select * from {0}", tableName), conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Load(rdr);
                        return tbl;

                    }
                }
            }

        }


        public static DataTable GetPagedRecordsFromTable(string tableName, string idField, int pageSize, int index, string SortedField, List<string> fieldsToFilter, string filterBeginsWithOrContains, string filterTextToFind)
        {
            string queryFilter;

            if (fieldsToFilter != null)
                queryFilter = GetQueryFilter(fieldsToFilter, filterBeginsWithOrContains, filterTextToFind);
            else
                queryFilter = null;



            using (SqlConnection conn = new SqlConnection(connString.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetSortedPage", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TableName", tableName));
                    cmd.Parameters.Add(new SqlParameter("@PrimaryKey", idField));
                    cmd.Parameters.Add(new SqlParameter("@SortedField", SortedField));
                    cmd.Parameters.Add(new SqlParameter("@PageSize", pageSize== 0 ? 50 : pageSize));
                    cmd.Parameters.Add(new SqlParameter("@PageIndex", index == 0 ? 1 : index));
                    cmd.Parameters.Add(new SqlParameter("@QueryFilter", queryFilter));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable tbl = new DataTable();
                        tbl.Load(rdr);
                        return tbl;

                    }
                }
            }
        }

    }
}
