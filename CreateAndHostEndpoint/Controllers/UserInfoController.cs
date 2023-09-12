using Microsoft.AspNetCore.Mvc;

namespace CreateAndHostEndpoint.Controllers
{
    [ApiController]
    [Route("api/user-info")]
    public class UserInfoController: ControllerBase
    {

        
        [HttpGet]
        public IActionResult GetInfo(string slackName, string track)
        {
            var userInfo = new UserInformation
            {
                SlackName = slackName,
                DayOfWeek = DateTime.UtcNow.ToString("dddd"),
                Track= track,


            };

        }
    }
}
