using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Curso
    {
        #region PROPIEDADES
        public int ID_curso { get; set; }
        public string tipoCurso { get; set; }
        //public string descripcion { get; set; }
        public bool activo { get; set; }
        public Aeronave aeronave { get; set; }
        public decimal horasVoladas { get; set; }
        public Piloto alumno { get; set; }

        //int ID_aeronave (que me lo traiga automaticamente al seleccionar la aeronave)
        //analizar si agregar fecha de inicio y finalizacion del mismo
        #endregion

        #region METODOS
        #endregion
    }
}
