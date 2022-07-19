using DependencyInjectionPOC.Interface;
using DependencyInjectionPOC.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDependencyInjectionController : ControllerBase
    {
        private readonly ILogger<TestDependencyInjectionController> _logger;

        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        //private readonly IScopedService _scopedService1;
        //private readonly IScopedService _scopedService2;

        //private readonly ITransientService _transientService1;
        //private readonly ITransientService _transientService2;

        public TestDependencyInjectionController(ILogger<TestDependencyInjectionController> logger,

            ISingletonService singletonService1,
            ISingletonService singletonService2

            //IScopedService scopedService1,
            //IScopedService scopedService2,

            //ITransientService transientService1,
            //ITransientService transientService2

            )
        {
            _logger = logger;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

            //_scopedService1 = scopedService1;
            //_scopedService2 = scopedService2;

            //_transientService1 = transientService1;
            //_transientService2 = transientService2;

        }


        [HttpGet]
        [Route("Singleton")]
        public IActionResult GetSingleton()
        {
            return Ok(new SingletonResponse
            {
                SingletonResponse1 = _singletonService1.GetOperationID().ToString(),
                SingletonResponse2 = _singletonService2.GetOperationID().ToString()
            });
        }

        //[HttpGet]
        //[Route("Scoped1")]
        //public IActionResult GetScoped1()
        //{
        //    return Ok(new ScopedResponse
        //    {
        //        ScopedResponse1 = _scopedService1.GetOperationID().ToString(),
        //        ScopedResponse2 = _scopedService2.GetOperationID().ToString()
        //    });
        //}

        //[HttpGet]
        //[Route("Scoped2")]
        //public IActionResult GetScoped2()
        //{
        //    return Ok(new ScopedResponse
        //    {
        //        ScopedResponse1 = _scopedService1.GetOperationID().ToString(),
        //        ScopedResponse2 = _scopedService2.GetOperationID().ToString()
        //    });
        //}

        //[HttpGet]
        //[Route("Transient")]
        //public IActionResult GetTransient()
        //{
        //    return Ok(new TransientResponse
        //    {
        //        TransientResponse1 = _transientService1.GetOperationID().ToString(),
        //        TransientResponse2 = _transientService2.GetOperationID().ToString()
        //    });
        //}
    }
}
