using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiCollege.Models.EF;
using PagedList;

namespace WikiCollege.Models.Dao
{
    public class ContentDao
    {
        WikiCollegeDBContext db = new WikiCollegeDBContext();
        public IEnumerable<CONTENT> ListAllPaging(int page, int pageSize)
        {
            return db.CONTENT.OrderByDescending(x=> x.created_date).ToPagedList(page, pageSize);
        }
        public int Insert(CONTENT ct)
        {
            //if (ModelState.IsValid)
            {
                CONTENT obj = new CONTENT();
                obj.author_ID = 0;
                obj.meta_title = ct.meta_title;
                obj.title = ct.title;
                obj.desciption = ct.desciption;
                obj.image = ct.image;
                obj.detail = ct.detail;
                obj.created_date = DateTime.Now;
                obj.status = ct.status;
                if (ct.top_hot == null)
                    obj.top_hot = DateTime.Now.AddDays(7);
                else
                    obj.top_hot = ct.top_hot;
                obj.view_count = ct.view_count;
                obj.tags = ct.tags;
                db.CONTENT.Add(obj);
                db.SaveChanges();
            }
            return 1;
        }
    }
}