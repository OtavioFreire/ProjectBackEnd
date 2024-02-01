using Api.Application;
using Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Project.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ExampleReceiver _ExampleReceiver;

        [HttpGet(Name = "GetNomes")]
        public List<ExampleModel> getNomes() 
        {
            _ExampleReceiver = new ExampleReceiver();

            return _ExampleReceiver.GetNomes();
        }
    }
}
