using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiCollege.Models.EF;

namespace WikiCollege.Models.Dao
{
    public class AccountDao
    {
        WikiCollegeDBContext db = new WikiCollegeDBContext();
        public int Insert(ACCOUNT acc)
        {
            db.ACCOUNTS.Add(acc);
            db.SaveChanges();
            return acc.acc_ID;
        }
        public ACCOUNT getByUserName(string username)
        {
            return db.ACCOUNTS.SingleOrDefault(x => x.user_name == username);
        }
        public string Login(string username, string password)
        {
            var check = db.ACCOUNTS.SingleOrDefault(x => x.user_name == username);
            if (check == null)
                return "user-404";
            if (check.acc_type != "admin" && check.acc_type != "sysuser")
                return "not-allowed";
            if (check.status == false)
                return "blocked";
            if (check.pass_word != password)
                return "wrong-pass";
            else
                return "ok";
        }
    }
}