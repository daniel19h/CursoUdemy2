namespace WebApiAutores2Udemy.Middlewares
{
    // metodo de extension
    public static class LoguearResouestaHTTPMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoguearResouestaHTTP(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoguearResouestaHTTPMiddleware>();
        }
    }
    public class LoguearResouestaHTTPMiddleware
    {

        private readonly RequestDelegate siguiente;
        private readonly ILogger<LoguearResouestaHTTPMiddleware> logger;

        public LoguearResouestaHTTPMiddleware(RequestDelegate siguiente, ILogger<LoguearResouestaHTTPMiddleware> logger)
        {
            this.siguiente = siguiente;
            this.logger = logger;
        }

        // Invoke o InvokeAsync
        public async Task InvokeAsync(HttpContext contexto)
        {
            //guardar en memoria para que el ciente pueda leerla
            using (var ms = new MemoryStream())
            {
                // respuesta
                var cuerpoOriginalRespuesta = contexto.Response.Body;
                contexto.Response.Body = ms;

                await siguiente(contexto);

                // despues de esta linea, de este awad, se va a ejecutar cuando ya los porteriores me esten devolviendo un respuesta

                // 
                ms.Seek(0, SeekOrigin.Begin);
                string respuesta = new StreamReader(ms).ReadToEnd();

                ms.Seek(0, SeekOrigin.Begin);

                await ms.CopyToAsync(cuerpoOriginalRespuesta);
                contexto.Response.Body = cuerpoOriginalRespuesta;

                logger.LogInformation(respuesta);
            }
        }
    }
}
