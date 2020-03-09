using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MerchantService.Application.UseCases.UserMediator.Commands;
using MerchantService.Model;

namespace MerchantService.Controller
{
    [ApiController]
    [AllowAnonymous]
    [Route("authenticate")]

    public class UserController : ControllerBase
    {
        private IMediator _mediatr;

        public UserController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PostUserCommand data)
        {
            var result = await _mediatr.Send(data);
            return Ok(result);
        }
    }
}
