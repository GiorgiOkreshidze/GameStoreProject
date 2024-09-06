using Microsoft.AspNetCore.Mvc.Filters;

namespace Gamestore.Middlewares.Filter;

public class ActionRight(string action) : ActionFilterAttribute
{
    private readonly string _action = action;

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine(_action);
        base.OnActionExecuting(context);
        throw new System.Exception("jemal");
    }
}