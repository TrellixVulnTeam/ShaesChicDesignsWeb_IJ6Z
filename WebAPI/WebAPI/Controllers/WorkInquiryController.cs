using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkInquiryController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly WorkContext _workContext;

        public WorkInquiryController(IConfiguration configuration, WorkContext workContext )
        {
            _configuration = configuration;
            _workContext = workContext;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_workContext.WorkInquiries.ToListAsync());
        }


        [HttpPost]
        public JsonResult Post(WorkInquiry workInquiry)
        {
            _workContext.WorkInquiries.Add(workInquiry);
            _workContext.SaveChangesAsync();
            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(WorkInquiry workInquiry)
        {
            return new JsonResult("Updated Successfully");
        }


        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            return new JsonResult("Deleted Successfully");
        }
    }
}
