using CosmeticFinder.FE.Gateways;
using Refit;

namespace CosmeticFinder.FE.Extensions
{
    public static class Refit
    {
        //todo: move to appsettings
        private const string BaseUrl = "https://localhost:5001";

        public static void AddRefitConfiguration(this IServiceCollection services)
        {
            services
                .AddRefitClient<ICosmeticFinder>()
                .ConfigureHttpClient(client =>
                {
                    client.BaseAddress = new Uri(BaseUrl);
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                });
        }
    }
}
