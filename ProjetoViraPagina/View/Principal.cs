using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textPesquisa.PlaceholderText = "Pesquisar";
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void labelAcervos_Click(object sender, EventArgs e)
        {

        }

        private void labelReservas_Click(object sender, EventArgs e)
        {

        }

        private void labelPenalidades_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
