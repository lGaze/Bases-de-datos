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
  
    
    public partial class Form1 : Form
    {
       

        String strDefault = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}";
        String strDe = "{0,-10}{1,-20}{2,-25}{3,-25}{4,-25}{5,-25}";

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tabla.Items.Add(String.Format(strDefault, "ID", "Nombre", "Apellido1", "Apellido2", "Fecha_Nacimiento", "Estado_Nacimiento"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2(this);
            f2.Show();

           
        }
        public void SetSelectedItemValue(string Nombre,string Apellido1, string Apellido2, string Fecha, string Estado)
        {
           
            Tabla.Items.Add(String.Format(strDe, i++, Nombre, Apellido1, Apellido2, Fecha, Estado));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iQuitar;
            iQuitar = MessageBox.Show("Confirm if you want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iQuitar == DialogResult.Yes)
            {
                Tabla.Items.Remove(Tabla.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //to do.
        }
    }
}
