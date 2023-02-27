using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Licencias;
using CONTEXTO;
using MODELO;


namespace CONTROLADORA
{
    public class Licencias
    {
        private static Licencias instancia;
        Aeroclub oAeroclub;

        public static Licencias ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Licencias();
            }
            return instancia;
        }

        private Licencias()
        {
            oAeroclub = new Aeroclub();
        }

        public List<Licencia> ObtenerLicencia()
        {
            return GestionaLicencias.ObtieneLicencia(oAeroclub);

        }
    }
}
