using Microsoft.AspNetCore.Mvc;

namespace TherapEase_API.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class PatientDataController : ControllerBase
        {
            private static readonly string[] Summaries = new[]
            {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

            private readonly ILogger<PatientData> _logger;

            public PatientDataController(ILogger<PatientData> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetTestPatient")]
            public IEnumerable<PatientData> Get()
            {
                return Enumerable.Range(1, 5).Select(index => new PatientData
                {
                    Name = "Test name",
                    BirtDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Age = 15,
                    HealthCode = "A94-4",
                    DateJoined = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                })
                .ToArray();
            }
        }
}
