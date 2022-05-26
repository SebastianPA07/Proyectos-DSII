using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cédula
{
    public partial class Form1 : Form
    {
        List<Persona> persona = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void Borrar()
        {
            foreach (Control Borrar in gbGeneral.Controls)
            {
                if (Borrar is TextBox)
                {
                    Borrar.Text = string.Empty;
                }
            }

            MessageBox.Show("Campos eliminados");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var Personas = new Persona
            {
                Cedula = txtCedula.Text,
                LugarNacimiento = txtLugarNacimiento.Text,
                FechaNacimiento = FechaNacimiento.Value,
                Nacionalidad = txtNacionalidad.Text,
                Sangre = cbSangre.Text,
                Sexo = cbSexo.Text,
                EstadoCivil = cbEstadoCivil.Text,
                Ocupacion = txtOcupacion.Text,
                FechaDeExpiracion = FechaDeExpiracion.Value,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
            };

            persona.Add(Personas);

            MessageBox.Show("Cédula agregada");

            Borrar();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            dgVista.Enabled = true;

            GuardarPersonas();
        }

        private void GuardarPersonas()
        {
            dgVista.DataSource = null;
            dgVista.DataSource = persona;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
        public class Persona
        {
            public string Cedula { get; set; }
            public string LugarNacimiento { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Sexo { get; set; }
            public string Sangre { get; set; }
            public string EstadoCivil { get; set; }
            public string Ocupacion { get; set; }
            public DateTime FechaDeExpiracion { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
        }

       
     

