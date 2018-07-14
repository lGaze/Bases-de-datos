using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Base_de_datos
{
    public partial class Form2 : Form
    {




        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }
        private readonly Form1 _form1;

        public String Nombre { get { return txtNombre.Text; } }
        public String Apellido1 { get { return txtApellido1.Text; } }
        public String Apellido2 { get { return txtApellido2.Text; }  }
        public String FechaNacimiento { get { return txtFecha.Text; }  }
        public String EstadoNAcimiento { get { return txtEstado.Text; }  }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Visible=false;
            
            _form1.SetSelectedItemValue(Nombre, Apellido1, Apellido2, FechaNacimiento, EstadoNAcimiento);
          
            
        }
    }
}
