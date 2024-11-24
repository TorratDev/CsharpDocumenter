using Hangfire;

namespace BatchDocumentationTool;

public static class HangfireConfiguration
{
    public static void ConfigureHangfire(IServiceCollection services, IConfiguration configuration)
    {
        services.AddHangfire(config =>
        {
            config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                ;
        });

        services.AddHangfireServer();
    }
}