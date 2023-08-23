﻿using FluentValidation;
using CarWorkshop.Application.Mappings;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;

namespace CarWorkshop.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCarWorkshopCommand));

            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));

            services.AddValidatorsFromAssemblyContaining<CreateCarWorkshopCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
                
        }
    }
}
