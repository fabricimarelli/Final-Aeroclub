using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{



    public class Licencia
    {
        public int ID_Licencia { get; set; }
        public string nombreLicencia { get; set; }
        public string descripLicencia { get; set; }

        public static List<Licencia> LicenciasDisponibles = new List<Licencia> {
        new Licencia { ID_Licencia = 1, nombreLicencia = "Privado",descripLicencia="Piloto privado" },
        new Licencia { ID_Licencia = 2, nombreLicencia = "Comercial",descripLicencia="Piloto comercial" },
        new Licencia { ID_Licencia = 3, nombreLicencia = "Instrumentos",descripLicencia="Vuelo por instrumenos" },
        new Licencia { ID_Licencia = 4, nombreLicencia = "Primera clase",descripLicencia="Piloto comercial primer clase" },
        };
    }   
}
