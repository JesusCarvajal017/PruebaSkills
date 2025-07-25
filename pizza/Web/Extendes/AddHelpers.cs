﻿using FluentValidation;
using FluentValidation.AspNetCore;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;
using Utilities.Helpers.Validations.Pizza;

namespace Web.Extendes
{
    public static class AddHelpers
    {
        public static IServiceCollection AddHelpersValidation(this IServiceCollection services)
        {
            services.AddScoped<IGenericHerlpers, GenericHelpers>();
            services.AddValidatorsFromAssemblyContaining<ClienteValidation>();
            services.AddFluentValidationAutoValidation();

            return services;

        }
    }
}
