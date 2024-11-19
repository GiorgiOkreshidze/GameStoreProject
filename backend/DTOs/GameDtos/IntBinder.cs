using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DTOs.GameDtos;

public class IntBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName).FirstValue;

        if (string.IsNullOrEmpty(value) || value == "all")
        {
            bindingContext.Result = ModelBindingResult.Success(0); // default value
        }
        else if (int.TryParse(value, out int intValue))
        {
            bindingContext.Result = ModelBindingResult.Success(intValue);
        }
        else
        {
            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Invalid integer value");
        }

        return Task.CompletedTask;
    }
}