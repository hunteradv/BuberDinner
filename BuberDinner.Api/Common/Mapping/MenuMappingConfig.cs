﻿using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Contracts.Menus;
using BuberDinner.Domain.MenuAggregate;
using Mapster;
using MenuSection = BuberDinner.Domain.MenuAggregate.Entities.MenuSection;
using MenuItem = BuberDinner.Domain.MenuAggregate.Entities.MenuItem;

namespace BuberDinner.Api.Common.Mapping
{
    public class MenuMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(CreateMenuRequest Request, string HostId), CreateMenuCommand>()
                .Map(dest => dest.HostId, src => src.HostId)
                .Map(dest => dest, src => src.Request);

            config.NewConfig<Menu, MenuResponse>()
                .Map(dest => dest.Id, src => src.Id.Value)
                .Map(dest => dest.AverageRating, src => src.AverageRating.Value)
                .Map(dest => dest.HostId, src => src.HostId.Value)
                .Map(dest => dest.DinnerIds, src => src.DinnerIds.Select(dinnerId => dinnerId.Value))
                .Map(dest => dest.MenuReviewIds, src => src.MenuReviewIds.Select(reviewId => reviewId.Value))
                .Map(dest => dest, src => src);
            
            config.NewConfig<MenuSection, MenuResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);

            config.NewConfig<MenuItem, MenuResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);
        }
    }
}
