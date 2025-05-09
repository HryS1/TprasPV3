namespace AppManFilm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btntambah = new Button();
            btnedit = new Button();
            btnhapus = new Button();
            clientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(776, 41);
            label1.TabIndex = 0;
            label1.Text = "Aplikasi Manajemen Film";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btntambah
            // 
            btntambah.Location = new Point(20, 107);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(112, 34);
            btntambah.TabIndex = 1;
            btntambah.Text = "Tambah";
            btntambah.UseVisualStyleBackColor = true;
            btntambah.Click += btntambah_Click;
            // 
            // btnedit
            // 
            btnedit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnedit.Location = new Point(489, 109);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(112, 34);
            btnedit.TabIndex = 2;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnhapus
            // 
            btnhapus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnhapus.Location = new Point(659, 107);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(112, 34);
            btnhapus.TabIndex = 3;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            btnhapus.Click += btnhapus_Click;
            // 
            // clientsTable
            // 
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.ColumnHeadersVisible = false;
            clientsTable.Location = new Point(20, 165);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.RowHeadersWidth = 62;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(751, 442);
            clientsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(clientsTable);
            Controls.Add(btnhapus);
            Controls.Add(btnedit);
            Controls.Add(btntambah);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aplikasi Manajemen Film_Prasetyo 3J";
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btntambah;
        private Button btnedit;
        private Button btnhapus;
        private DataGridView clientsTable;
    }
}
