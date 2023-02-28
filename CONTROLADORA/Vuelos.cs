using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Vuelos;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Vuelos
    {
        private static Vuelos instancia;
        Aeroclub oAeroclub;

        public static Vuelos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Vuelos();
            }
            return instancia;
        }

        private Vuelos()
        {
            oAeroclub = new Aeroclub();
        }



        public List<Vuelo> ObtenerVuelos()
        {
            return GestionaVuelos.ObtieneVuelo(oAeroclub);
        }

        public void AgregarVuelo(Vuelo Vuelo)
        {
            OperacionesVuelos.AgregarVuelo(oAeroclub, Vuelo);
            oAeroclub.SaveChanges();
        }

        public void EliminarVuelo(Vuelo Vuelo)
        {
            OperacionesVuelos.EliminarVuelos(oAeroclub, Vuelo);
            oAeroclub.SaveChanges();
        }

        public void ModificarVuelo(Vuelo Vuelo)
        {
            oAeroclub.SaveChanges();
        }

        public List<Vuelo> ObtenerVuelosAVION(string matricula)
        {

            return CASOS_USO.Vuelos.GestionaVuelos.ObtenerVuelosAVION(oAeroclub, matricula);
        }

    }

}
