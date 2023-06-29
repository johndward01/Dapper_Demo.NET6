using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Demo.NET6;
internal class CustomViewModel
{
    public IEnumerable<Product> Computers { get; set; }
    public IEnumerable<Product> Appliances { get; set; }
    public IEnumerable<Product> Phones { get; set; }

}
