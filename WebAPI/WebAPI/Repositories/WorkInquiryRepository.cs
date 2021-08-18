using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Repositories.Interfaces;

namespace WebAPI.Repositories
{
    public class WorkInquiryRepository : IWorkInquiryRepository
    {
        private readonly WorkContext _workContext;
        public WorkInquiryRepository(WorkContext workContext)
        {
            _workContext = workContext;
        }

        public DbSet<WorkInquiry> Get()
        {
            return _workContext.WorkInquiries;
        }

        public int Post(WorkInquiry workInquiry)
        {
            _workContext.WorkInquiries.Add(workInquiry);
            return _workContext.SaveChangesAsync().Result;
        }
    }
}
