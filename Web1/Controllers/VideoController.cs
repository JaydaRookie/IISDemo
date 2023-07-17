using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Web1.Controllers
{
    [MyAuthentication]
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        public VideoController() { }

        [AllowAnonymous]
        [TestingFilter]
        [HttpGet]
        public string Get()
        {
            return "this is a string";
        }

        [TestingFilter]
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            if( User.Identity.IsAuthenticated )
            {
                return $"this is a string with id = {id}";
            }
            else
            {
                return "Unautenticated Identity";
            }
           
        }


        [TestingFilter]
        [HttpGet("authentication")]
        public IActionResult TestAuthentication()
        {
            Debug.Write("AuthenticationType:" + User.Identity?.AuthenticationType);
            Debug.Write("IsAuthenticated:" + User.Identity?.IsAuthenticated);
            Debug.Write("Name:" + User.Identity?.Name);

            if ( User.Identity.IsAuthenticated )
            {
                return Ok("Authenticated: " + User.Identity?.Name);
            }
            else
            {
                return BadRequest("Not authenticated");
            }
        }
    }
}
