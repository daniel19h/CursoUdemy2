using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebApiAutores2Udemy.Utilidades
{
    public class SwaggerAgrupaPorVersion : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var namespaceControlador = controller.ControllerType.Namespace; // controller.v1
            var versionAPI = namespaceControlador.Split('.').Last().ToLower(); //v1
            controller.ApiExplorer.GroupName = versionAPI;
        }
    }
}
