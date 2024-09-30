﻿using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OneInc.Server.Web.Common;

namespace OneInc.Server.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {

        services.AddHttpContextAccessor();

        services.AddControllers();

        services.AddExceptionHandler<ApiExceptionHandler>();
        services.AddProblemDetails();
        
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);


        services.AddSwaggerGen();

        return services;
    }
}
