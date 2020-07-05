using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args) => 
            Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(_ => _
                .Configure(_ => _
                    .Run(_ => _
                        .Response
                        .WriteAsync("2"))))
            .Build()
            .Run();
    }
}
