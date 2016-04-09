using NCMA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCMA.Common;

namespace NCMA.Services
{
    public class DojoService : ServiceBase
    {
        public IEnumerable<dojo> GetDojos()
        {
            using (db = new NcmaModel())
            {
                return db.dojoes.OrderByDescending(d => d.Name);
            }
        }

        public dojo GetDojo(int dojoId)
        {
            using (db = new NcmaModel())
            {
                return db.dojoes
                    .Where(d => d.ID == dojoId)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<member> GetInstructorsForDojo(int dojoId)
        {
            using (db = new NcmaModel())
            {
                return db.members
                    .Where(m => m.DojoID == dojoId)
                    .Where(m => m.MemberTypeID == (int)MemberTypes.Instructor);
            }
        }
    }
}
