// using Microsoft.AspNetCore.Mvc;
// using Shared;  // Import the Shared namespace

// namespace SPO.Services
// {
//     [Route("api/test")]
//     [ApiController]
//     public class TestController : ControllerBase
//     {
//         [HttpGet]
//         public IActionResult GetMessage()
//         {
//             Class1 abc = new Class1();
//             return Ok();
//         }
//     }
// }


using Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Shared;
using web;
using ZstdSharp.Unsafe;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Controller{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController : SPOBaseController
    {
        private readonly ITestBusinessLogic _bl;
        public TestController(ITestBusinessLogic bl) : base()
        {   
            _bl = bl;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public async Task<List<studentDetails>> GetAllStudents()
        {
            return await _bl.GetAllStudents();
        }
    }
}