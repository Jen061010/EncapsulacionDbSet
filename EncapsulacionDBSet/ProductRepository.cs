using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulacionDBSet
{
    public class ProductRepository:RepositoryBase<Product>,IProductRepository
    {
        readonly IContext _ctx;
        public ProductRepository(IContext ctx)
            :base(ctx)
        {
            if (null == ctx) 
            {
                throw new ArgumentNullException("ctx");
            }
            _ctx = ctx;
            _ctx.CreateSet<Ticket>();
        }
        public IEnumerable<Product> GetAll() 
        {
            return Entity.Select(c=>c);
            

        }
    }
}
