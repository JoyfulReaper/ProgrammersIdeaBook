
using System.Collections.Generic;

namespace ChangeReturnProgram
{
    public interface IProductListRequester
    {
        void ProductsUpdates(List<Product> products);
    }
}
