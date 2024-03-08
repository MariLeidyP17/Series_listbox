using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGUNDO_EJERCICIO_CONTROLES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            list_serie.Items.Add("" +txt_series.Text);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
