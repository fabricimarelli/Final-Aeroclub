using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Vuelos
{
    public class GestionaVuelos
    {
        public static List<Vuelo> ObtieneVuelo(Aeroclub aeroclub)
        {
            return aeroclub.Vuelos.ToList();
        }


        public static List<MODELO.Vuelo> ObtenerVuelosAVION(Aeroclub aeroclub, string matricula)
        {
            var vuelos = from Vuelos in aeroclub.Vuelos.Include("matricula")
                         where (matricula != null ? Vuelos.aeronave.matricula == matricula : true)
                         select Vuelos;
            return vuelos.ToList();
        }


    }
}