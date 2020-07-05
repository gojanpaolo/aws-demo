using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main() => 
        Host
        .CreateDefaultBuilder()
        .ConfigureWebHostDefaults(_ => _
            .Configure(_ => _
                .Run(_ => _
                    .Response
                    .WriteAsync("4"))))
        .Build()
        .Run();
}
