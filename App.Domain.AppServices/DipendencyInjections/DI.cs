﻿using App.Domain.Core.Products.Contracts.AppServices;
using App.Domain.Core.Users.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.DipendencyInjections
{
    public static class DI
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IUserAppServices, UserAppServices>();
            services.AddScoped<IProductAppServices, ProductAppServices>();
            services.AddScoped<ICommentAppServices, CommentAppServices>();
            services.AddScoped<IShopAppServices, ShopAppServices>();
            return services;
        }
    }
}
