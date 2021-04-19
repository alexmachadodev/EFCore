namespace EFCoreAdvanced.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public int EmployeeId { get; set; }
        public Department Department { get; set; }

    }
}