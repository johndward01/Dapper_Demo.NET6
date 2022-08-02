using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Demo.NET6;

public interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllDepartments();
}
