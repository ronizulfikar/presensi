namespace presensi
{
    partial class ceoform
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnama = new TextBox();
            txtkelas = new TextBox();
            txtkelompokbelajar = new TextBox();
            label4 = new Label();
            txtketerangan = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabelketeranganpelajar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 42);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "kelas";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 71);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "kelompok belajar";
            label3.Click += label3_Click;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(112, 10);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(356, 23);
            txtnama.TabIndex = 3;
            // 
            // txtkelas
            // 
            txtkelas.Location = new Point(111, 39);
            txtkelas.Name = "txtkelas";
            txtkelas.Size = new Size(357, 23);
            txtkelas.TabIndex = 4;
            // 
            // txtkelompokbelajar
            // 
            txtkelompokbelajar.Location = new Point(111, 68);
            txtkelompokbelajar.Name = "txtkelompokbelajar";
            txtkelompokbelajar.Size = new Size(357, 23);
            txtkelompokbelajar.TabIndex = 5;
            txtkelompokbelajar.TextChanged += txtkelompokbelajar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 100);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "keterangan";
            label4.Click += label4_Click;
            // 
            // txtketerangan
            // 
            txtketerangan.Location = new Point(111, 97);
            txtketerangan.Name = "txtketerangan";
            txtketerangan.Size = new Size(357, 23);
            txtketerangan.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(378, 232);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 8;
            button1.Text = "input";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(288, 233);
            button2.Name = "button2";
            button2.Size = new Size(83, 27);
            button2.TabIndex = 9;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(193, 233);
            button3.Name = "button3";
            button3.Size = new Size(86, 27);
            button3.TabIndex = 10;
            button3.Text = "keluar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(111, 233);
            button4.Name = "button4";
            button4.Size = new Size(76, 26);
            button4.TabIndex = 11;
            button4.Text = "export";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabelketeranganpelajar
            // 
            tabelketeranganpelajar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelketeranganpelajar.Location = new Point(7, 133);
            tabelketeranganpelajar.Name = "tabelketeranganpelajar";
            tabelketeranganpelajar.RowTemplate.Height = 25;
            tabelketeranganpelajar.Size = new Size(465, 93);
            tabelketeranganpelajar.TabIndex = 12;
            // 
            // ceoform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 262);
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
            Name = "ceoform";
            Text = "ceoform";
            Load += ceoform_Load;
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnama;
        private TextBox txtkelas;
        private TextBox txtkelompokbelajar;
        private Label label4;
        private TextBox txtketerangan;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView tabelketeranganpelajar;
    }
}