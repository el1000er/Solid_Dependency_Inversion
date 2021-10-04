using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class SQLProductRepository:IProductRepository
    {
        public List<string> GetAllProductNames()
        {
       
            return new List<string> { "soap", "toothpaste" };
        }
    }
}
