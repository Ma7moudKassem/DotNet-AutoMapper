namespace DotNet_AutoMapper;

public class ProfileMapper : Profile
{
	public ProfileMapper()
	{
		CreateMap<Employee, EmployeeDto>()
			.ForMember(e=>e.EmpId,e=>e.MapFrom(e=>e.Id))
			.ForMember(e=>e.IsInetrn , e=>e.MapFrom(e=>e.Salary == 0))
			.ReverseMap();
	}
}
