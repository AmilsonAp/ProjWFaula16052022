using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {

        public  Produto Produto { get; set; }
        public  Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
