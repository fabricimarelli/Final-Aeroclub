using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Socios;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Socios
    {
        private static Socios instancia;
        Aeroclub oAeroclub;

        public static Socios ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Socios();
            }
            return instancia;
        }

        private Socios()
        {
            oAeroclub=new Aeroclub();
        }

        public List<Socio> ObtenerSocios()
        {
            return GestionaAeroanves.ObtieneSocio(oAeroclub);
        }

        public void AgregarSocio(Socio socio)
        {
            OperacionesAeronaves.AgregarSocio(oAeroclub, socio);
            oAeroclub.SaveChanges();
        }

        public void EliminarSocio(Socio socio)
        {
            OperacionesAeronaves.EliminarSocios(oAeroclub, socio);
            oAeroclub.SaveChanges();
        }

        public void ModificarSocio(Socio socio)
        {
            oAeroclub.SaveChanges();
        }

        public List<Socio> ObtenerSocioDNI(int DNI)
        {
            return CASOS_USO.Socios.GestionaAeroanves.ObtenerSocioDNI(oAeroclub, DNI);
        }

    }

}
