using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_Gurlove.Models
{
    public class Designation
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<EmployeeDetail> EmployeeDetail { get; set; }

    }
}
