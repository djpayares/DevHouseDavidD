using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevHouseDavid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string nombre;
        int edad;
        double estatura;

        public void button1_Click(object sender, EventArgs e)
        {
            #region SACAR EDAD

            nombre = Convert.ToString(textBox1.Text);
            estatura = Convert.ToDouble(textBox2.Text);
            DateTime Fecha = DateTime.Today;
            edad = Fecha.Year - dateTimePicker1.Value.Year;
            #endregion
            if ((edad < 0)||(edad > 100)||(estatura < 0)||(estatura > 3))
            {
                MessageBox.Show("Dato Invalido");

            }else if((edad >= 15) && (edad <= 18) && (estatura >1.50) && (estatura < 2))
            {
                MessageBox.Show(nombre + " puede estar en el equipo");
            }
            else
            {
                MessageBox.Show(nombre + " no puede estar en el equipo");
            }
            
        }

        
    }
}
