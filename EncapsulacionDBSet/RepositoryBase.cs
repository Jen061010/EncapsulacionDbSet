using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulacionDBSet
{
    public class RepositoryBase<T> where T:class
    {
        readonly IContext _context;
        public RepositoryBase(IContext context)
        {
            _context = context;
        }
        protected IDbSet<T> Entity
        {
            get 
            {
                return _context.CreateSet<T>();
            }        
        }
    }
}
