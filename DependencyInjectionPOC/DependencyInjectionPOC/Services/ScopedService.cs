using DependencyInjectionPOC.Interface;

namespace DependencyInjectionPOC.Services
{
    public class ScopedService : IScopedService
    {     
        Guid id;
        public ScopedService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
