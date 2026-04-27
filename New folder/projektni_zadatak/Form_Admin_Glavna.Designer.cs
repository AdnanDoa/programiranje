namespace projektni_zadatak
{
    partial class Form_Admin_Glavna
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
            DataGridViewNarudzbe = new DataGridView();
            buttonOsvjezi = new Button();
            buttonObrisi = new Button();
            narudzba_id = new DataGridViewTextBoxColumn();
            kupac = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridViewNarudzbe).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewNarudzbe
            // 
            DataGridViewNarudzbe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewNarudzbe.Columns.AddRange(new DataGridViewColumn[] { narudzba_id, kupac, datum });
            DataGridViewNarudzbe.Location = new Point(32, 54);
            DataGridViewNarudzbe.Name = "DataGridViewNarudzbe";
            DataGridViewNarudzbe.Size = new Size(344, 52);
            DataGridViewNarudzbe.TabIndex = 0;
            // 
            // buttonOsvjezi
            // 
            buttonOsvjezi.Location = new Point(250, 112);
            buttonOsvjezi.Name = "buttonOsvjezi";
            buttonOsvjezi.Size = new Size(126, 36);
            buttonOsvjezi.TabIndex = 1;
            buttonOsvjezi.Text = "Osvježi";
            buttonOsvjezi.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            buttonObrisi.Location = new Point(250, 171);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(126, 42);
            buttonObrisi.TabIndex = 2;
            buttonObrisi.Text = "Obriši narudžbu";
            buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // narudzba_id
            // 
            narudzba_id.HeaderText = "ID narudžbe";
            narudzba_id.Name = "narudzba_id";
            // 
            // kupac
            // 
            kupac.HeaderText = "Kupac";
            kupac.Name = "kupac";
            // 
            // datum
            // 
            datum.HeaderText = "Datum";
            datum.Name = "datum";
            // 
            // Form_Admin_Glavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 274);
            Controls.Add(buttonObrisi);
            Controls.Add(buttonOsvjezi);
            Controls.Add(DataGridViewNarudzbe);
            Name = "Form_Admin_Glavna";
            Text = "Form_Admin_Glavna";
            ((System.ComponentModel.ISupportInitialize)DataGridViewNarudzbe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewNarudzbe;
        private Button buttonOsvjezi;
        private Button buttonObrisi;
        private DataGridViewTextBoxColumn narudzba_id;
        private DataGridViewTextBoxColumn kupac;
        private DataGridViewTextBoxColumn datum;
    }
}