using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProveedorEntity: DBEntity
    {
        public int? IdProveedor { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrmierApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int? Edad { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;


    }
}
