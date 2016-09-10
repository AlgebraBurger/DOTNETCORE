using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Startup
    {
       public void Configure(IApplicationBuilder app)
       {
            
            app.Run(c => c.Response.WriteAsync("Hello from the end of the pipeline"));
       }
    }
}
