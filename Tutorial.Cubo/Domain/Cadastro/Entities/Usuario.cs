using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cadastro.Entities
{
    public class Usuario
    {
        public virtual Decimal Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Senha { get;set; }

        public virtual string Email { get;set; }
    }
}
