using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Vuelo
    {
        #region PROPIEDADES
        public int ID_vuelo { get; set; }
        public Aeronave aeronave { get; set; }
        public Piloto piloto { get; set; }
        public int ID_socio { get; set; }
        public int nroFactura { get; set; }
        public DateTime fechaHoraSalida { get; set; }
        public DateTime fechaHoraLlegada { get; set; }
        public decimal taquimSalida { get; set; }
        public decimal taquimLlegada { get; set; }
        public decimal tiempo { get; set; }//metodo que lo calcule a partir del taquimetro salida/llegada
        public string desdeLugar { get; set; }
        public string hastaLugar { get; set; }
        public int aterrizajes { get; set; }
        public string finalidad { get; set; }
        public bool diurno { get; set; }
        public bool nocturno { get; set; }//metodo que lo autocomplete calculando las horas de salida/llegada
        public decimal tarifa { get; set; }//metodo que calcule la tarifa a partir del costo de hora de vuelo (tarifaHora-clase Aeronave) y tiempo volado
        public string observaciones { get; set; }
        #endregion

        #region METODOS
       public void Obtiene_IDsocio()
        {
           
        }
        #endregion

    }

    public class Instruccion : Vuelo
    {
        #region PROPIEDADES
        //Alumno alumno { get; set; }
        
        //ID_SocioAlum
        

        //agregar metodo nuevo para calular tarifa (sumar costo de instruccion)
        #endregion

        #region METODOS
        #endregion
    }


}
