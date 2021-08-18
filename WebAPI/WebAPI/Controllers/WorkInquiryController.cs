using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Repositories.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkInquiryController : ControllerBase
    {
        private readonly IWorkInquiryRepository _workInquiryRepository;

        public WorkInquiryController(IWorkInquiryRepository workInquiryRepository, WorkContext workContext)
        {
            _workInquiryRepository = workInquiryRepository;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_workInquiryRepository.Get());
        }


        [HttpPost]
        public JsonResult Post(WorkInquiry workInquiry)
        {
            int result = _workInquiryRepository.Post(workInquiry);
            if(result > 0)
                return new JsonResult("Added Successfully");
            else
                return new JsonResult("Work Inquiry NOT added!");
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
