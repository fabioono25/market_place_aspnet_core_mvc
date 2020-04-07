using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(MarketPlace.Areas.Identity.IdentityHostingStartup))]
namespace MarketPlace.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}