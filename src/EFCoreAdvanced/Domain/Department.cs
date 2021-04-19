using System.Collections.Generic;

namespace EFCoreAdvanced.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ICollection<Employee> Employees { get; set; }
}
}