using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;


namespace CASOS_USO.Licencias
{
    public class GestionaLicencias
    {
        public static List<Licencia> ObtieneLicencia(Aeroclub aeroclub)
        {
            return aeroclub.Licencias.ToList();
        }
    }
}
