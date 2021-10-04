using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
  public  class ProductCatalog
    {
        public void ListAllProducts()
        {
            //instead of directly instanciating the sqlRepository, we will invoke the factory method and get the object
            //SQLProductRepository sqlProductRepository = new SQLProductRepository();

            IProductRepository productRepository = ProductFactory.Create();
            //Hence we will be fixing the violation and we are now following the dependency inversion priciple.
            //ProductCatalog no longer depends on  SQLProductRepository (doesn't even know if it comes from SQL,ORACLE Or anywhere else)
            //Both high level module and low level module depends on Abstraction (IProductRepository)

            productRepository.GetAllProductNames();
            //here the high level module  (Product Catalog) is dependant on low level module (SQLProductRepository)
            //hence violating the dependency inversion principle, to avoid this we will have to create an interface and a factorya

        }
    }
}