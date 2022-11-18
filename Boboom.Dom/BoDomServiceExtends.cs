using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Boboom.Dom;

public static class BoDomServiceExtends
{
    public static IServiceCollection AddBoboomDomService(this IServiceCollection services)
    {
        services.AddSingleton(sp => new BoDom(sp.GetRequiredService<IJSRuntime>()));
        return services;
    }
}
