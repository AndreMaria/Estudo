using APIGeo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace APIGeo.Repository
{
    public class PrincipalRepository : Base<Principal>
    {
        public Principal Save(Principal principal)
        {
            if (principal.Id == 0)
                principal.Id = this.Add(principal);
            else
                this.Update(principal);
            return principal;
        }

        public List<Principal> FindByText(string texto)
        {
            Expression<Func<Principal, bool>> filter = x => x.Texto.Contains(texto) || x.Texto.ToUpper().Contains(texto.ToUpper());
            return this.Find(filter);
        }
    }
}
