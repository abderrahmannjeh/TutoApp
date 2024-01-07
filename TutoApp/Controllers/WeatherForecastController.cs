using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICategoryService<CategoryDTO, Category> categoryService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICategoryService<CategoryDTO, Category> categoryService)
        {
            _logger = logger;
            this.categoryService = categoryService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<CategoryDTO>> Get()
        {
            return await categoryService.GetAll();
        }
    }

}