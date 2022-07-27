using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApiAutores2Udemy.Utilidades
{
    // IOperationFilter que viene de aspentcore
    public class AgregarParametrosHATEOAS : IOperationFilter
    {

        
        // indicar cuando quiero que aplique este parametro
        void IOperationFilter.Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            // con este codigo colocamos 
            if (context.ApiDescription.HttpMethod != "GET")
            {
                return;
            }

            if (operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "incluirHATEOAS",
                In = ParameterLocation.Header,
                Required = false
            });

        }
    }
}
