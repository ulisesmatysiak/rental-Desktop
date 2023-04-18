using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Rent
    {
        public int Id { get; set; }

        public string Cliente { get; set; }

        public Fecha Fecha { get; set; }

        public Spot Spot { get; set; }

        public decimal Importe { get; set; }
    }
}
