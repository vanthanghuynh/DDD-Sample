using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Common
{
    public interface IRepository<T> 
    {
        Task SaveAsync(T entity);
    }
}
