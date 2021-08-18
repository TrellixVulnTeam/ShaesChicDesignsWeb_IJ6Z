using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories.Interfaces
{
    public interface IWorkInquiryRepository
    {
        Task<List<WorkInquiry>> Get();
        int Post(WorkInquiry workInquiry);
    }
}
