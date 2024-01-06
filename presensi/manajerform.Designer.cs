namespace presensi
{
    partial class manajerform
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
            button2 = new Button();
            button1 = new Button();
            txtketerangan = new TextBox();
            label4 = new Label();
            txtkelompokbelajar = new TextBox();
            txtkelas = new TextBox();
            txtnama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            tabelketeranganpelajar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(276, 259);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 19;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(371, 259);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 18;
            button1.Text = "input";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtketerangan
            // 
            txtketerangan.Location = new Point(126, 99);
            txtketerangan.Name = "txtketerangan";
            txtketerangan.Size = new Size(333, 23);
            txtketerangan.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 102);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 16;
            label4.Text = "keterangan";
            // 
            // txtkelompokbelajar
            // 
            txtkelompokbelajar.Location = new Point(126, 70);
            txtkelompokbelajar.Name = "txtkelompokbelajar";
            txtkelompokbelajar.Size = new Size(333, 23);
            txtkelompokbelajar.TabIndex = 15;
            // 
            // txtkelas
            // 
            txtkelas.Location = new Point(126, 41);
            txtkelas.Name = "txtkelas";
            txtkelas.Size = new Size(333, 23);
            txtkelas.TabIndex = 14;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(126, 12);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(333, 23);
            txtnama.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 12;
            label3.Text = "kelompok belajar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "kelas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "nama";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 259);
            button3.Name = "button3";
            button3.Size = new Size(83, 27);
            button3.TabIndex = 20;
            button3.Text = "keluar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(104, 259);
            button4.Name = "button4";
            button4.Size = new Size(77, 27);
            button4.TabIndex = 21;
            button4.Text = "export";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabelketeranganpelajar
            // 
            tabelketeranganpelajar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelketeranganpelajar.Location = new Point(7, 130);
            tabelketeranganpelajar.Name = "tabelketeranganpelajar";
            tabelketeranganpelajar.RowTemplate.Height = 25;
            tabelketeranganpelajar.Size = new Size(458, 118);
            tabelketeranganpelajar.TabIndex = 22;
            tabelketeranganpelajar.CellContentClick += tabelketeranganpelajar_CellContentClick;
            // 
            // manajerform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 298);
            Controls.Add(tabelketeranganpelajar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtketerangan);
            Controls.Add(label4);
            Controls.Add(txtkelompokbelajar);
            Controls.Add(txtkelas);
            Controls.Add(txtnama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "manajerform";
            Text = "manajerform";
            Load += manajerform_Load;
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtketerangan;
        private Label label4;
        private TextBox txtkelompokbelajar;
        private TextBox txtkelas;
        private TextBox txtnama;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
        private DataGridView tabelketeranganpelajar;
    }
}