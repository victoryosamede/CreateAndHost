using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CreateAndHostEndpoint.Controllers
{
    [ApiController]
    [Route("api/user-info")]
    public class UserInfoController: ControllerBase
    {

        
        [HttpGet]
        public IActionResult GetInfo(string slackName = "Victory Uhunmwangho", string track = "backend")
        {

            var userInfo = new UserInformation
            {
                SlackName = slackName,
                DayOfWeek = DateTime.UtcNow.ToString("dddd"),
                CurrentUtcTime = DateTime.UtcNow,
                Track= track,
                GithubFileUrl = "https://github.com/victoryosamede/CreateAndHost/blob/main/CreateAndHostEndpoint/Controllers/UserInfoController.cs",
                GithubRepoUrl = "https://github.com/victoryosamede/CreateAndHost.git",
                StatusCode = 200

            };
            return Ok(userInfo);

        }
    }
}
