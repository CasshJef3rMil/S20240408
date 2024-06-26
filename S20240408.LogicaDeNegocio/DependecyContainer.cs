﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using S20240408.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S20240408.LogicaDeNegocio
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddScoped<SpersonaBL>();
            return services;
        }
    }
}
