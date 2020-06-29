using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiCollege.Models.EF;
using PagedList;

namespace WikiCollege.Models.Dao
{
    public class AccountDao
    {
        WikiCollegeDBContext db = new WikiCollegeDBContext();
        public int Insert(ACCOUNT acc)
        {
            acc.created_date = DateTime.Now;
            db.ACCOUNTS.Add(acc);
            db.SaveChanges();
            return acc.acc_ID;
        }

        public bool Update(ACCOUNT acc)
        {
            Console.WriteLine(acc.acc_ID);
            var account = db.ACCOUNTS.Find(acc.acc_ID);
            var x = account.acc_ID;
            if (account == null)
                return false;
            account.acc_type = acc.acc_type;
            account.user_name = acc.user_name;
            account.full_name = acc.full_name;
            account.email = acc.email;
            account.address = acc.address;
            account.phone = acc.phone;
            account.status = acc.status;
            db.SaveChanges();
            return true;
        }

        public ACCOUNT getByUserName(string username)
        {
            return db.ACCOUNTS.SingleOrDefault(x => x.user_name == username);
        }

        public ACCOUNT ViewDetail(int id)
        {
            var x = db.ACCOUNTS.Find(id);
            return db.ACCOUNTS.Find(id);
        }

        public ACCOUNT getByID(int id)
        {
            return db.ACCOUNTS.SingleOrDefault(x=> x.acc_ID == id);
        }

        public IEnumerable<ACCOUNT> ListAllPaging(int page, int pageSize)
        {
            return db.ACCOUNTS.OrderByDescending(x => x.created_date).ToPagedList(page, pageSize);
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