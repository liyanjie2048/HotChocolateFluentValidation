namespace Liyanjie.HotChocolate.FluentValidation;

public static class ArgumentDescriptorExtensions
{
    public static IArgumentDescriptor UseFluentValidation(this IArgumentDescriptor descriptor)
    {
        descriptor.Extend().OnBeforeCreate(definition => definition.ContextData[Extensions.Key_UseFluentValidation] = true);

        return descriptor;
    }
}
