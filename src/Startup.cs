using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) => app.Run(c => c.Response.WriteAsync("1"));
    }
}
