using CRTBuisnessLogics.Managers.Admin;
using CRTWebApi.Model;
using CRTWebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRTWebApi.Controllers
{
    [Route("api/Admin/")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMaster _master;
        public ICategoryManager category;


        public AdminController(IMaster mater,ICategoryManager _category)
        {
            _master = mater;
            this.category = _category;
        }
        [HttpGet]
        [Route("/GetAll")]
        public List<Master> GetAll()
        {

            var data = _master.Getall();
            return data.Result.ToList<Master>();
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var data = _master.GetById(id);
            return Ok(data);
        }
        [HttpGet("getall")]
        public IActionResult GetAllCategories()
        {
            return Ok (category.getallitem());
        }
    }
}

