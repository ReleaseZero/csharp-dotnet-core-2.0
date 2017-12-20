using Microsoft.AspNetCore.Mvc.Filters;

namespace ReleaseZero.Service.Infrastructure
{
	/// <summary>
	/// Attribute for validating models
	/// </summary>
    public class ValidateModelAttribute : ActionFilterAttribute
    {
		/// <summary>
		/// OnActionExecuting handler
		/// </summary>
		/// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (!context.ModelState.IsValid)
			{
				context.Result = new ValidationFailedResult(context.ModelState);
			}
		}
    }
}