# HotChocolate FluentValidation

- #### Create and register your validator to DI
- #### Add the extend method to HotChocolate's IRequestExecutorBuilder
    ```csharp
    // builder is IRequestExecutorBuilder
    builder.AddFluentValidation(options =>
    {
        /// <summary>
        /// If true, only mutation input parameters with [UseFluentValidation] can be validate,
        /// else all mutation input parameters will try to be validate.
        /// Default value is false, set true can improve performance.
        /// </summary>
        options.UseFluentValidationAttribute = true;
    });
    ```
- #### [UseFluentValidation] is required when you set "options.UseFluentValidationAttribute=true"
    ```csharp
    public class Mutation
    {
        public async Task<Payload> MutationMethod(
            [UseFluentValidation] Input input)
        {
            ...
        }
    }
    ```