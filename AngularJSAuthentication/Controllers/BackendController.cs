using WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using GenericServices;
using WebModel;
using Dapper;
//using System.Web.Mvc;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Backend")]
    public class BackendController : ApiController
    {
        private AuthRepository _repo = null;

        public BackendController()
        {
            _repo = new AuthRepository();
        }
        //View ds tin đăng(Đức)
        public IHttpActionResult GetAllHouses()
        {
            GenericService<House> generic = new GenericService<House>();
            var data = generic.ExcuteMany("getAllHouses", null);
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult GetAllHouses(House model)
        {
            GenericService<House> generic = new GenericService<House>();
            var param = new DynamicParameters();
            param.Add("@Param", model.cus_ID);
            var data = generic.ExcuteMany("getAllHouses", null);
            return Ok(data);
        }
        //View chi tiết tin đăng(Đức)
        //Các quyền: cho đăng tin, quyền xóa tin(Người dùng) (Đức)


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}