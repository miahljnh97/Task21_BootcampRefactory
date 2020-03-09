
using System.Threading.Tasks;
using CustomerService.Application.UseCases.UserMediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Task18_BootcampRefactory.Controller
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
