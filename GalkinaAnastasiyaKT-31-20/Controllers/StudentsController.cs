using Microsoft.AspNetCore.Mvc;
using GalkinaAnastasiyaKT_31_20.Filters.StudentFilters;
using GalkinaAnastasiyaKT_31_20.Interfaces.StudentsInterfaces;

namespace GalkinaAnastasiyaKT_31_20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController>? _logger;
        private readonly IStudentService _studentService;

        public StudentsController(ILogger<StudentsController> logger, IStudentService studentService)
        {
            _logger = logger;   
            _studentService = studentService;
        }
        [HttpPost(Name = "GetStudentsByGroup")]
        public async Task<IActionResult> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
           var students = await _studentService.GetStudentsByGroupAsync(filter, cancellationToken);
            return Ok(students);
        }
    }
}
