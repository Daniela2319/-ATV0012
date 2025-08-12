using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class BaseModel
    {
        private static int contadorId = 0; // começa em 1 (evita id = 0)

        public int Id { get; set; } // cada instância terá seu próprio Id

        public BaseModel()
        {
            contadorId++;
            Id = contadorId;
        }
    }

}
