namespace Liyanjie.HotChocolate.FluentValidation;

public class UseFluentValidationOptions
{
    /// <summary>
    /// If true, only mutation input parameters with [UseFluentValidation] can be validate,
    /// else all mutation input parameters will try to be validate.
    /// </summary>
    public bool UseFluentValidationAttribute { get; set; }

    /// <summary>
    /// Custom how to report ValidationResult.Errors
    /// </summary>
    public Action<IMiddlewareContext, ValidationResult>? ReportValidationError { get; set; }
}
