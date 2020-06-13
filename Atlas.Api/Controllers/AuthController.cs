using Application.Auth.ListRoles;
using Application.Auth.ListUsers;
using Application.Auth.Register;
using Atlas.Application.Auth.Login;
using Atlas.Application.Auth.ResetPassword;
using Atlas.Application.Auth.UpdatePassword;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atlas.Api.Controllers
{
    public class AuthController : ApiController
    {
        [HttpGet]
        [Route("ListUsers")]
        public async Task<ActionResult<List<UserDTO>>> ListUsers()
        {
            return await Mediator.Send(new ListUsersQuery());
        }

        [HttpGet]
        [Route("ListRoles")]
        public async Task<ActionResult<List<string>>> ListRoles()
        {
            return await Mediator.Send(new ListRolesQuery());
        }

        [HttpGet]
        [Route("ResetPassword/{Username}")]
        [Authorize(Roles = "Atlas_Admin")]
        public async Task<ActionResult> ResetPassword(string Username)
        {
            return Ok(await Mediator.Send(new ResetPasswordCommand(Username)));
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<string>> Register(RegisterUserCommand user)
        {
            return await Mediator.Send(user); 
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginCommand login)
        {
            return Ok(new {token = await Mediator.Send(login) });
        }

        [HttpPost]
        [Route("UpdatePassword")]
        [Authorize]
        public async Task<ActionResult> UpdatePassword(UpdatePasswordCommand updatePassword)
        {
            return Ok( await Mediator.Send(updatePassword));
        }
    }
}
