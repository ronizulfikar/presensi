namespace presensi
{
    partial class karyawanform
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
            tabelketeranganpelajar = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).BeginInit();
            SuspendLayout();
            // 
            // tabelketeranganpelajar
            // 
            tabelketeranganpelajar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelketeranganpelajar.Location = new Point(38, 49);
            tabelketeranganpelajar.Name = "tabelketeranganpelajar";
            tabelketeranganpelajar.RowTemplate.Height = 25;
            tabelketeranganpelajar.Size = new Size(326, 183);
            tabelketeranganpelajar.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(262, 249);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 1;
            button1.Text = "keluar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // karyawanform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 283);
            Controls.Add(button1);
            Controls.Add(tabelketeranganpelajar);
            Name = "karyawanform";
            Text = "karyawanform";
            Load += karyawanform_Load;
            ((System.ComponentModel.ISupportInitialize)tabelketeranganpelajar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelketeranganpelajar;
        private Button button1;
    }
}