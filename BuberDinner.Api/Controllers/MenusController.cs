using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Contracts.Menus;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("hosts/{hostId}/menus")]
    public class MenusController : ApiController
    {
        private readonly IMapper _mapper;

        public MenusController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateMenu(CreateMenuRequest request, string hostId)
        {
            //var command = _mapper.Map<CreateMenuCommand>((request, ))

            return Ok(request);
        }
    }
}
