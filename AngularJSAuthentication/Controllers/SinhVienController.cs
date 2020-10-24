using GenericServices;
using System.Web.Http;
using WebModel;

namespace WebAPI.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SinhVienController : ApiController
    {
        public IHttpActionResult GetAll2()
        {
            GenericService<SinhVien> generic = new GenericService<SinhVien>();
            var data = generic.ExcuteMany("SinhVien_getAll",null);
            return Ok(data);
        }
        //[HttpPost]
        //public IHttpActionResult PostData(SinhVien sv)
        //{
        //    data.Add(sv);
        //    return Ok();
        //}
    }
}
