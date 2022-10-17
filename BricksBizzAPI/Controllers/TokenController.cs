using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BricksBizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
       // private readonly JwtSettings jwtSettings;

        //public TokenController(JwtSettings jwtSettings)
        //{
            //jwtSettings = jwtSettings;
        //}

        //private IEnumerable<Users> logins = new List<Users>() {
            //new Users() {
                    //Id = Guid.NewGuid(),
                        //EmailId = "lahukumbhar@gmail.com",
                        //UserName = "Admin",
                        //Password = "Admin",
                //},
                //new Users() {
                    //Id = Guid.NewGuid(),
                        //EmailId = "aartikumbhar@gmail.com",
                        //UserName = "Aartikumbhar",
                        //Password = "Admin",
                //}
        //};

        //[HttpPost]
        //public IActionResult GetToken(UserLogins userLogins)
        //{
            //try
            //{
                //var Token = new UserTokens();
                //var Valid = logins.Any(x => x.UserName.Equals(userLogins.UserName, StringComparison.OrdinalIgnoreCase));
                //if (Valid)
                //{
                    //var user = logins.FirstOrDefault(x => x.UserName.Equals(userLogins.UserName, StringComparison.OrdinalIgnoreCase));
                    //Token = JwtHelpers.JwtHelpers.GenTokenkey(new UserTokens()
                    //{
                        //EmailId = user.EmailId,
                        //GuidId = Guid.NewGuid(),
                        //UserName = user.UserName,
                        //Id = user.Id,
                    //}, jwtSettings);
                //}
                //else
                //{
                    //return BadRequest("wrong password");
                //}
                //return Ok(Token);
            //}
            //catch (Exception ex)
            //{
                //throw;
            //}
        //}
    }
}
