using Dapper;
using GenericServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebModel;

namespace AngularJSAuthentication.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult CreateHouse(int cus_ID , int street_ID , int district_ID,
            int province_ID , int area_ID , int ward_ID, string prop_1,string prop_2,string prop_3)
        {
                GenericService<House> generic = new GenericService<House>();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@cus_ID", cus_ID);
                parameter.Add("@street_ID", street_ID);
                parameter.Add("@district_ID", district_ID);
                parameter.Add("@province_ID", province_ID);
                parameter.Add("@area_ID", area_ID);
                parameter.Add("@ward_ID", ward_ID);
                parameter.Add("@prop_1", prop_1);
                parameter.Add("@prop_2", prop_2);
                parameter.Add("@prop_3", prop_3);

                var stdList = generic.ExcuteNoneQuery("pro_add_house", parameter);
            return Json("OK");
        }
        //public ActionResult Edit()
        //{
        //    GenericService<House> generic = new GenericService<House>();
        //    DynamicParameters parameter = new DynamicParameters();
        //    parameter.Add("@tutor_id", .id);
        //    var stdList = generic.ExcuteNoneQuery("pro_edit_all_house", parameter);
        //    return PartialView(stdList);
        //}
        //public ActionResult CreateHouse()
        //{
        //    GenericService<House> generic = new GenericService<House>();
        //    DynamicParameters parameter = new DynamicParameters();
        //    parameter.Add("@tutor_id", .id);
        //    var stdList = generic.ExcuteMany("_Tutor_StudentChatList", parameter);
        //    return PartialView(stdList);
        //}
        //public ActionResult CreateHouse()
        //{
        //    GenericService<House> generic = new GenericService<House>();
        //    DynamicParameters parameter = new DynamicParameters();
        //    parameter.Add("@tutor_id", .id);
        //    var stdList = generic.ExcuteMany("_Tutor_StudentChatList", parameter);
        //    return PartialView(stdList);
        //}
    }
}