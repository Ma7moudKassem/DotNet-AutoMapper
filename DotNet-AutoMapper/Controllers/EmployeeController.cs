namespace DotNet_AutoMapper;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IMapper _mapper;
    public EmployeeController(IMapper mapper) => _mapper = mapper;

    List<Employee> employees = new()
    {
        new Employee {Id = 1, FirstName = "Mahmoud" , LastName = "Kassem" , Age = 21, Salary = 5000 },
        new Employee {Id = 2, FirstName = "Ahmed" , LastName = "Mohamed" , Age = 18, Salary = 3000 },
        new Employee {Id = 3, FirstName = "Mody" , LastName = "Hussien" , Age = 16, Salary = 0 },
    };

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        IEnumerable<EmployeeDto> employeeDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return Ok(employeeDtos);
    }

    [HttpGet("{id}")]
    public IActionResult Details(int id)
    {
        Employee? employee = employees.SingleOrDefault(e => e.Id == id);
        return Ok(_mapper.Map<EmployeeDto>(employee));
    }

    [HttpPost]
    public IActionResult Creat(EmployeeDto dto) => Ok(_mapper.Map<Employee>(dto));
}
