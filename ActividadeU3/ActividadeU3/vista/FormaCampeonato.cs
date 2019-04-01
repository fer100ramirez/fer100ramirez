using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadeU3.vista
{
    public partial class FormaCampeonato : Form
    {
        private string path = "c:\\temp\\campeonato.txt";
        public FormaCampeonato()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main s = new Main();
            s.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaJornada n = new FormaJornada();
            n.Show();
            this.Hide();
        }
        private void LoadGrid()
        {
            datos.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            datos.Rows.Clear(); //si hay datos los elimina
            datos.AllowUserToAddRows = false; //permite agregar registros
        }

    }
}
