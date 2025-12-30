namespace HireMeNow_MVC_Application.Models.DTOs
{
    public class JobDTO
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Experience { get; set; }
        public string? TypeOfWorkPlace { get; set; }
        public string? Salary { get; set; }

        public string? CompanyName { get; set; }
        public Guid CompanyId { get; set; }
        public JobDTO() { }
        public JobDTO(string title,string description,string location,string salary,string typeofworkplace,Guid companyid,string company,Guid?id
            =null)
        {
            Id = id ?? new Guid();
            Title = title;
            Description= description;
            Location = location;
            Salary = salary;
            TypeOfWorkPlace = typeofworkplace;
            CompanyName = company;
            CompanyId = companyid;

        }
    }
}
