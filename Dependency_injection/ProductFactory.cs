using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion

{
   public class ProductFactory
    {
        public static IProductRepository Create()
        {
            return new SQLProductRepository();
        }
    }
}
