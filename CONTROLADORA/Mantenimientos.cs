using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASOS_USO.Aeronaves;
using CONTEXTO;
using MODELO;

namespace CONTROLADORA
{
    public class Mantenimientos
    {
        private static Mantenimientos instancia;


        public static Mantenimientos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Mantenimientos();
            }
            return instancia;
        }


        Aeroclub oAeroclub;

        private Mantenimientos()
        {
            oAeroclub = Aeroclub.obtener_instancia();
        }

        public List<Aeronave> ObtenerAeronaves()
        {
            return GestionaAeroanves.ObtieneAeronaves(oAeroclub);
        }

        public void AgregarAeronave(Aeronave Aeronave)
        {
            OperacionesAeronaves.AgregarAeronave(oAeroclub, Aeronave);
            oAeroclub.SaveChanges();
        }

        public void EliminarAeronave(Aeronave Aeronave)
        {
            OperacionesAeronaves.EliminarAeronaves(oAeroclub, Aeronave);
            oAeroclub.SaveChanges();
        }

        public void ModificarAeronave(Aeronave Aeronave)
        {
            oAeroclub.SaveChanges();
        }

        public List<Aeronave> ObtenerAeronavematricula(int ID_aeronave)
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtenerAeronaveMAT(oAeroclub, ID_aeronave);
        }

        public Aeronave ObtenerUNAAeronave(string matricula)
        {
            return CASOS_USO.Aeronaves.GestionaAeroanves.ObtenerUNAAeronave(oAeroclub, matricula);
        }

    }

}