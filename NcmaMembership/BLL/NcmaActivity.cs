using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;

namespace NcmaMembership.BLL
{
    public static class NcmaActivity
    {
        public enum ActivityType : int { JOIN = 1, REUP, REJOIN, LEFT, TERM, AWARD, RANK, PAID };

        public static MyNcmaEntities db = new MyNcmaEntities();
        public static bool JOIN(int memID,string activitydesc="Joined the NCMA" )
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool REUP(int memID, string activitydesc="Re-upped Membership")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool REJOIN(int memID, string activitydesc="Rejoined the NCMA")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool LEFT(int memID, string activitydesc = "Quit the NCMA")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool TERM(int memID, string activitydesc="Fired from the NCMA")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool AWARD(int memID, string activitydesc="Tournament Award")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool RANK(int memID, string activitydesc="Promotion")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }
        public static bool PAID(int memID ,string activitydesc="Payment Processed")
        {
            return SaveActivity(memID, activitydesc, ActivityType.JOIN);
        }

        private static bool SaveActivity(int memID, string activitydesc, ActivityType t)
        {
            var m = new memberactivity();
            m.MemberID = memID;
            m.ActivityDate = DateTime.Now;
            m.TypeID = (int)t;
            m.ActivityDescription = activitydesc;
            db.memberactivities.AddObject(m);
            return db.SaveChanges() > 0;
        }

    }
}