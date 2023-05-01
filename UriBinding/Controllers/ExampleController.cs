using Microsoft.AspNetCore.Mvc;
using UriBinding.Model;

namespace UriBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ExampleCreateModel model)
        {
            //shouldn't even get here because the model binder should fail to bind because we've passed
            // a Uri of "string" and the automatic 400 error handling should be triggered. 

            //if you inspect the mode you'll see all the properties are throwing exceptions

            //if you look at the local modelstate, it will be IsValid = true


            return Created("", null);
        }
    }
}
