using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADORA;

namespace VISTA
{
    public partial class frmSocios : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmSocios instancia;
        public static frmSocios OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmSocios();
            if (instancia.IsDisposed)
                instancia = new frmSocios();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        private CONTROLADORA.Socios cSocios;
        private MODELO.Socio oSocio;
        char ACCION;
        // declaro una variable que me indica la acción
        //private MODELO.ACCION ACCION;

        public frmSocios()
        {
            InitializeComponent();
            cSocios=Socios.ObtenerInstancia();
            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = cSocios.ObtenerSocios();
            /*dgvSocios.Columns[0].HeaderText = "ID";
            dgvSocios.Columns[1].HeaderText = "Nombre";
            dgvSocios.Columns[2].HeaderText = "Apellido";
            dgvSocios.Columns[4].HeaderText = "Domicilio";
            dgvSocios.Columns[5].HeaderText = "Celular";
            dgvSocios.Columns[6].HeaderText = "Email";
            dgvSocios.ReadOnly = true;
            dgvSocios.AutoResizeColumn(0);*/
            

        }

        private void MODO_GRILLA()
        {
            gbDatosSocio.Enabled = false;
            gbListaSocios.Enabled = true;
        }

        private void MODO_DATOS()
        {
            gbListaSocios.Enabled = false;
            gbDatosSocio.Enabled = true;
            if (ACCION == 'C')
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
            

        }

        private void LIMPIAR()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtDNI.Clear();
            dtpFechaNacim.Value = DateTime.Now;
            txtCelular.Clear();
            txtEmail.Clear();
            txtID.Clear();
            rbAviacion.Checked = false;
            rbComun.Checked = true;
            cbAlumno.Checked = false;
            cbPiloto.Checked = false;
            cbListLicencias.ClearSelected();
            txtHorasVoladas.Clear();
            txtClaseCMA.Clear();
            dtpVencCMA.Value = DateTime.Now;

        }

        private void VUELCA_DATOS()
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un socio de la lista");
                return;
            }
            oSocio = (Socio)dgvSocios.CurrentRow.DataBoundItem;
            txtNombre.Text = oSocio.nombre;
            txtApellido.Text = oSocio.apellido;
            txtDomicilio.Text = oSocio.domicilio;
            txtDNI.Text = oSocio.DNI.ToString();
            txtCelular.Text = oSocio.celular;
            txtID.Text = oSocio.ID_socio.ToString();
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ACCION = 'A';
            MODO_DATOS();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ACCION = 'E';
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;

            MODO_DATOS();
            VUELCA_DATOS();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ACCION = 'C';
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            //oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;
            MODO_DATOS();
            VUELCA_DATOS();
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista");
                return;
            }
            oSocio = (MODELO.Socio)dgvSocios.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el socio " + oSocio.nombre + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cSocios.EliminarSocio(oSocio);
                ARMA_GRILLA();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = new Bitmap(opnfd.FileName);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_GRILLA();
        }

        private void rbAviacion_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAviacion.Checked)
                gbAviacion.Enabled = true;
            else
                gbAviacion.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            #region VALIDACIONES
            int DNI;
            if(!Int32.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("Ingrese un DNI valido");
            }
            #endregion
            if (ACCION == 'A')
            {
                if (rbComun.Checked = true)
                {
                    oSocio = new Socio();
                }
                if (rbAviacion.Checked = true)
                {
                    oSocio = new Piloto();
                }
            }
            oSocio.nombre = txtNombre.Text;
            oSocio.apellido = txtApellido.Text;
            oSocio.domicilio = txtDomicilio.Text;
            oSocio.DNI = DNI;
            oSocio.fechaNacimiento = dtpFechaNacim.Value.Date;
            oSocio.celular = txtCelular.Text;
            oSocio.email = txtEmail.Text;

            decimal horasVoladas = 0;
            if (rbAviacion.Checked = true)
            {
                if (cbPiloto.Checked = true)
                {
                    ((MODELO.Piloto)oSocio).esPiloto = true;
                }
                else
                {
                    ((MODELO.Piloto)oSocio).esPiloto = false;
                }
                
                if(!decimal.TryParse(txtHorasVoladas.Text, out horasVoladas))
                {
                    MessageBox.Show("Igrese las horas en formato correcto");
                    return;
                }
                ((MODELO.Piloto)oSocio).horasVoladas = horasVoladas;
                ((MODELO.Piloto)oSocio).claseCMA = txtClaseCMA.Text;
                ((MODELO.Piloto)oSocio).vencimientoCMA = dtpVencCMA.Value.Date;

            }

            if (ACCION == 'A')
            {
                
                cSocios.AgregarSocio(oSocio);
            }
            if (ACCION == 'E')
            {
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modificar los datos del socio " + oSocio.nombre + " ?", "ATENCION", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    cSocios.ModificarSocio(oSocio);
                    ARMA_GRILLA();
                }
            }

            MODO_GRILLA();
            ARMA_GRILLA();
            LIMPIAR();
        }
    }
}
