﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string domicilio { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public byte[] fotoPersona { get; set; }

    }   

    public class Socio : Persona
    {
        public int ID_socio { get; set; }
        public DateTime fechaAdmision { get; set; }

    }

    public class Piloto : Socio
    {
        public bool esPiloto { get; set; }
        //public List<Licencia> licencias { get; set; }
        public decimal horasVoladas { get; set; }
        public string claseCMA { get; set; }
        public DateTime vencimientoCMA { get; set; }

    }

}
