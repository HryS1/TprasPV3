using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppManFilm.Models;
using AppManFilm.Repositories;

namespace AppManFilm
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private int clientId = 0;

        public void EditClient(Client client)
        {
            this.Text = "Edit";
            this.lbTitle.Text = "Edit Film";

            this.lbId.Text = "" + client.id;
            this.tbFilm.Text = client.film;
            this.tbGenre.Text = client.genre;
            this.tbTahun.Text = client.tahun;
            this.tbSutradara.Text = client.sutradara;

            this.clientId = client.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.id = this.clientId;
            client.film = this.tbFilm.Text;
            client.genre = this.tbGenre.Text;
            client.tahun = this.tbTahun.Text;
            client.sutradara = this.tbSutradara.Text;


            var repo = new ClientRepositories();

            if (client.id == 0)
            {
                repo.CreateClient(client);
            }
            else
            {
                repo.UpdateClient(client);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
