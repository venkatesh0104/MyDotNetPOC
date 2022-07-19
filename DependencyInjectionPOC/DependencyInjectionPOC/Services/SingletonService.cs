using DependencyInjectionPOC.Interface;

namespace DependencyInjectionPOC.Services
{
    public class SingletonService : ISingletonService
    {
        Guid id;
        public SingletonService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}