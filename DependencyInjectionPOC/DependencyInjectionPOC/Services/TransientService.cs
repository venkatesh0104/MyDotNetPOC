using DependencyInjectionPOC.Interface;

namespace DependencyInjectionPOC.Services
{
    public class TransientService : ITransientService
    { 
        Guid id;
        public TransientService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
