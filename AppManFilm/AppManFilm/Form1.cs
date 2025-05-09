using System.Data;
using AppManFilm.Repositories;

namespace AppManFilm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadClients();
        }

        private void ReadClients()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Film");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Tahun");
            dataTable.Columns.Add("Sutradara");
            dataTable.Columns.Add("Date");

            var repo = new ClientRepositories();
            var clients = repo.GetClients();


            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Film"] = client.film;
                row["Genre"] = client.genre;
                row["Tahun"] = client.tahun;
                row["Sutradara"] = client.sutradara;
                row["Date"] = client.createdAt;

                dataTable.Rows.Add(row);
            }

            this.clientsTable.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // update the list of clients
                ReadClients();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);

            var repo = new ClientRepositories();
            var client = repo.GetClient(clientId);

            if (client == null) return;


            CreateEditForm form = new CreateEditForm();
            form.EditClient(client);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // update the list of clients
                ReadClients();
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);


            // Show confirm dialog
            DialogResult dialogResult =
                MessageBox.Show("Kamu Ingin Menghapus Ini?"
                , "Hapus Ini", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }


            var repo = new ClientRepositories();
            repo.DeleteClient(clientId);

            // Update the list of clients
            ReadClients();
        }
    }
}
