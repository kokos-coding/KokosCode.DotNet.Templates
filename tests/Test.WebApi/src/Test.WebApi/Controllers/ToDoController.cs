using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.WebApi.Models.InputModels;

namespace Test.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] CreateToDoInputModel model, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Ok());
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateToDoInputModel model, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Ok());
        }

        [HttpDelete("id:Guid")]
        public async Task<IActionResult> DeleteAsync([FromQuery] Guid id, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet("id:Guid")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] Guid id, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost("filtered")]
        public async Task<IActionResult> GetByFilterAsync([FromBody] GetToDosByFilterInputModel model, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Ok());
        }
    }
}