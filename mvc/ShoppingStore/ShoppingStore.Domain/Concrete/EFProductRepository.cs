using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingStore.Domain.Abstract;
using ShoppingStore.Domain.Entities;

namespace ShoppingStore.Domain.Concrete
{
    public class EFProductRepository: IProductRepository {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
