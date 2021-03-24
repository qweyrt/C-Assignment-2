using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    app.UseMiddleware();

    app.Run(async (context) =>
    {
            await context.Response.WriteAsync("Hello World!");
    });
}
