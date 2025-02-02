using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPF_Auth
{
    public class cpf_valida
    {
        private readonly ILogger<cpf_valida> _logger;

        public cpf_valida(ILogger<cpf_valida> logger)
        {
            _logger = logger;
        }

        [Function("cpf_valida")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
