using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Finist_TestTask.WebApi.Extension;

internal class SwaggerDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        foreach (var apiDescription in context.ApiDescriptions)
        {
            var controllerActionDescriptor = (ControllerActionDescriptor)apiDescription.ActionDescriptor;

            if (!controllerActionDescriptor.ControllerTypeInfo.FullName.Contains("Client"))
            {
                var key = "/" + apiDescription.RelativePath.TrimEnd('/');
                swaggerDoc.Paths.Remove(key);
            }
        }
    }
}