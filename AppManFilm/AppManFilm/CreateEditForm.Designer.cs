namespace AppManFilm
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            label1 = new Label();
            lbId = new Label();
            label2 = new Label();
            tbFilm = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbGenre = new TextBox();
            tbTahun = new TextBox();
            tbSutradara = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(660, 57);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Aplikasi Manajemen Film";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            lbTitle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 104);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click_1;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(189, 104);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 25);
            lbId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 155);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 3;
            label2.Text = "Film";
            // 
            // tbFilm
            // 
            tbFilm.Location = new Point(189, 155);
            tbFilm.Name = "tbFilm";
            tbFilm.Size = new Size(439, 31);
            tbFilm.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 218);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 283);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Tahun";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 353);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 7;
            label5.Text = "Sutradara";
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(189, 218);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(150, 31);
            tbGenre.TabIndex = 8;
            // 
            // tbTahun
            // 
            tbTahun.Location = new Point(189, 283);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(150, 31);
            tbTahun.TabIndex = 9;
            // 
            // tbSutradara
            // 
            tbSutradara.Location = new Point(189, 353);
            tbSutradara.Name = "tbSutradara";
            tbSutradara.Size = new Size(439, 31);
            tbSutradara.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(389, 432);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Kembali";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 525);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbSutradara);
            Controls.Add(tbTahun);
            Controls.Add(tbGenre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbFilm);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Buat Film";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbId;
        private Label label2;
        private TextBox tbFilm;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbGenre;
        private TextBox tbTahun;
        private TextBox tbSutradara;
        private Button btnSave;
        private Button btnCancel;
    }
}