﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTEXTO;
using MODELO;

namespace CASOS_USO.Socios
{
    public class GestionaSocios
    {
        public static List<Socio>ObtieneSocio(Aeroclub aeroclub)
        {
            return aeroclub.Socios.ToList();
        }
    }
}
