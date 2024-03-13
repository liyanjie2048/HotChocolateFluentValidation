namespace Microsoft.Extensions.DependencyInjection;

public static class RequestExecutorBuilderExtensions
{
    public static IRequestExecutorBuilder AddFluentValidation(this IRequestExecutorBuilder builder,
        Action<UseFluentValidationOptions>? configure = default)
    {
        builder.Services.Configure(configure ?? (options => { }));
        builder.TryAddTypeInterceptor<FluentValidationInterceptor>();

        return builder;
    }
}
