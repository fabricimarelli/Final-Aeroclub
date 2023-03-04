using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;

namespace VISTA
{
    public partial class frmReportes : Form
    {
        private static frmAviones instancia;
        public static frmAviones OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmAviones();
            if (instancia.IsDisposed)
                instancia = new frmAviones();
            return instancia;
        }

        private Aeronaves cAeronaves;

        public frmReportes()
        {
            InitializeComponent();
            cAeronaves = Aeronaves.ObtenerInstancia();
        }

        

    }
}
