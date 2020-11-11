using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNP_Assignment.Models
{
    public interface AdultManager
    {
        
        Task addAdult(Adult adult);
        Task<List<Adult>> getAllAdults();
        
    }
}
