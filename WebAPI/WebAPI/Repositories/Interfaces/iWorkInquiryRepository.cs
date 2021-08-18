using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Repositories.Interfaces
{
    public interface IWorkInquiryRepository
    {
        DbSet<WorkInquiry> Get();
        int Post(WorkInquiry workInquiry);
    }
}
