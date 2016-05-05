using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulacionDBSet
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        //le cambia el nombre de set a createset
        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }        
    }

    //Código malo:
    
     /* (using var ctx=new Context())
      {
       return ctx.Product;
      }*/
    
}
