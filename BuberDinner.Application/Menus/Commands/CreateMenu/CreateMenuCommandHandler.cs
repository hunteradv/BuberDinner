using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
    {
        private readonly IMenuRepository _repository;

        public CreateMenuCommandHandler(IMenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            //create menu
            var menu = Menu.Create(HostId.Create(request.HostId), request.Name, request.Description,
                request.Sections.ConvertAll(selection => MenuSection.Create(selection.Name, selection.Description,
                    selection.Items.ConvertAll(item => MenuItem.Create(item.Name, item.Description)))));

            //persist menu
            _repository.Add(menu);

            //return menu
            return menu;
        }
    }
}
