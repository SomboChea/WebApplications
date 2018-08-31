using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private IConfiguration configuration { get; set; }
        public JwtController(IConfiguration _config)
        {
            configuration = _config;
        }

        [AllowAnonymous]
        [HttpGet("token")]
        public IActionResult Token()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTsecretkey"]));
            var signincredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // For Admin
            var adminclaims = new[]
            {
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Name,"sb"),
                new Claim(ClaimTypes.HomePhone,"098765431")
              
            };
            var adminjwt = new JwtSecurityToken(
                issuer: "serverwebaddress",
                audience: "clientwebaddress",
                claims: adminclaims,
                signingCredentials: signincredential
                );
            var admintoken = new JwtSecurityTokenHandler().WriteToken(adminjwt);

            // For User
            var userclaims = new[]
            {

                new Claim(ClaimTypes.Role,"User"),
                new Claim(ClaimTypes.Name,"sl")
            };
            var userjwt = new JwtSecurityToken(
                issuer: "serverwebaddress",
                audience: "clientwebaddress",
                claims: userclaims,
                signingCredentials: signincredential
                );
            var usertoken = new JwtSecurityTokenHandler().WriteToken(userjwt);


            // End Return
            return Ok(new {
                admintoken=admintoken,
                usertoken=usertoken
            });
        }

        [HttpPost("admin")]
        [Authorize(Roles ="Admin")]
        public IActionResult Admin()
        {
           
            return Ok(new {
                result="Success"
            });
        }

        [HttpPost("user")]
        [Authorize(Roles ="User")]
        public IActionResult User()
        {
            return Ok(new
            {
                result = "Success"
            });
        }

        [HttpGet("test")]
        [Authorize]
        public IActionResult test()
        {
            var name = HttpContext.User.Identity as ClaimsIdentity;
            return Ok(new {
                id=name.FindFirst(ClaimTypes.HomePhone).Value
            });
        }
    }
}