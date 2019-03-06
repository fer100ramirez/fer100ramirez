using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActividadeU3.vista;

namespace ActividadeU3
{
    public partial class FormaHelloWord : Form
    {
        public FormaHelloWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaEstudiante forma = new FormaEstudiante();
            forma.Show();
            this.Hide(); //Esconder la forma.
        }
    }
}
