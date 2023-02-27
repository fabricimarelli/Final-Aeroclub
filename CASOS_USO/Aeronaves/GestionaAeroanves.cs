using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Aeronaves
{
    public class GestionaAeroanves
    {
        public static List<Aeronave>ObtieneAeronaves(Aeroclub aeroclub)
        {
            return aeroclub.Aeronaves.ToList();
        }


        public static List<Aeronave> ObtenerAeronaveMAT(Aeroclub aeroclub, string matricula)
        {
            var aeronaves = from Aeronaves in aeroclub.Aeronaves
                          where (matricula != null ? Aeronaves.matricula == matricula : true)
                          select Aeronaves;
            return aeronaves.ToList();
        }


    }
}
