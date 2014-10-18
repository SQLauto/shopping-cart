using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingStore.Domain.Abstract;
using ShoppingStore.Domain.Entities;

namespace ShoppingStore.Domain.Concrete
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}
