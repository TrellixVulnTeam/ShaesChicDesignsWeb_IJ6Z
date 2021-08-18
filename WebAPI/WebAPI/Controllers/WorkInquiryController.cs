using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<ActionResult<IEnumerable<WorkInquiry>>> Get()
        {
            return await _workInquiryRepository.Get().ToListAsync();
        }

        [HttpPost]
        public JsonResult Post(WorkInquiry workInquiry)
        {
            workInquiry.CreatedDate = DateTime.Now;
            int result = _workInquiryRepository.Post(workInquiry);
            if(result > 0)
                return new JsonResult("Added Successfully");
            else
                return new JsonResult("Work Inquiry NOT added!");
        }
    }
}
