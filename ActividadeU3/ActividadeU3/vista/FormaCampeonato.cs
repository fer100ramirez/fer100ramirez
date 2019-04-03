using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            if (File.Exists(path))
            {
                StreamReader leer = new StreamReader(path, Encoding.Default);
                string text;

                while((text = leer.ReadLine()) != null)
                {
                    string[] array = text.Split('|');
                    datos.Rows.Add(array);
                }
                leer.Close();

            }
            else
            {
                File.Create(path);
            }
        }
        private void FormaCampeonato_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msg = "";

            if(textNombre.Text.Length < 3 || textNombre.Text.Length > 50)
            {
                msg += "El nombre debe de estar comprendido entre 3 y 50 caracteres\n";
            }
            DateTime fechaInicio = new DateTime(dateInicio.Value.Year, dateInicio.Value.Month, dateInicio.Value.Day, 0, 0, 0);
            DateTime fechaFinal = new DateTime(dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day, 0, 0, 0);
            if(DateTime.Compare(fechaInicio, fechaFinal) >= 0)
            {
                msg = "\nLa fecha de inicio debe de ser menor a la fecha final";
            }
            if(msg.Length > 0)
            {
                MessageBox.Show(msg, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormaCampeonato campeonato = new FormaCampeonato();
                campeonato.Id = new Random().Next(1, 1000);
                campeonato.Name = textNombre.Text;
                campeonato.fechaInicio = dateInicio.Value;
                campeonato.fechaFin = dateInicio.Value;

                string[] array = campeonato.ToString().Split(new char[] { '|' });
                datos.Rows.Add(array);
                datos.Rows.Add(array);
                AddRecordFile(campeonato);
                msg = "Registro agregado exitosamente";
                MessageBox.Show(msg, "Agrega un campeonato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddRecordFile(FormaCampeonato campeonato)
        {
            StreamWriter escribir = new StreamWriter(path, true);

            escribir.WriteLine(campeonato.ToString());
            escribir.Close();
        }
    }
}
