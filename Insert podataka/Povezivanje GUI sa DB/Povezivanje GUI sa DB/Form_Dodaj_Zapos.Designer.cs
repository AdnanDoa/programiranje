namespace Povezivanje_GUI_sa_DB
{
    partial class Form_Dodaj_Zapos
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
            groupBox1 = new GroupBox();
            dateTimePickerDatum = new DateTimePicker();
            label6 = new Label();
            label1 = new Label();
            comboBoxPosao = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBoxSifra = new TextBox();
            textBoxKorisnickoIme = new TextBox();
            buttonDodajZaposlenika = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxIme = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxMail = new TextBox();
            menuStrip1 = new MenuStrip();
            mENIToolStripMenuItem = new ToolStripMenuItem();
            licniPodaciToolStripMenuItem = new ToolStripMenuItem();
            odjaviSeToolStripMenuItem = new ToolStripMenuItem();
            label9 = new Label();
            label10 = new Label();
            textboxobriši = new TextBox();
            obriši = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerDatum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxPosao);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxSifra);
            groupBox1.Controls.Add(textBoxKorisnickoIme);
            groupBox1.Controls.Add(buttonDodajZaposlenika);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxIme);
            groupBox1.Controls.Add(textBoxTelefon);
            groupBox1.Controls.Add(textBoxPrezime);
            groupBox1.Controls.Add(textBoxMail);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 24);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(542, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje novog zaposlenika";
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDatum.Format = DateTimePickerFormat.Short;
            dateTimePickerDatum.Location = new Point(374, 27);
            dateTimePickerDatum.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(158, 23);
            dateTimePickerDatum.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(253, 29);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 18;
            label6.Text = "Datum zaposlenja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(310, 54);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 17;
            label1.Text = "ID posla:";
            // 
            // comboBoxPosao
            // 
            comboBoxPosao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPosao.FormattingEnabled = true;
            comboBoxPosao.Location = new Point(374, 52);
            comboBoxPosao.Margin = new Padding(3, 2, 3, 2);
            comboBoxPosao.Name = "comboBoxPosao";
            comboBoxPosao.Size = new Size(158, 23);
            comboBoxPosao.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(332, 106);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 15;
            label7.Text = "Šifra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(273, 81);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 14;
            label8.Text = "Korisničko ime:";
            // 
            // textBoxSifra
            // 
            textBoxSifra.Font = new Font("Segoe UI", 9F);
            textBoxSifra.Location = new Point(374, 104);
            textBoxSifra.Margin = new Padding(3, 2, 3, 2);
            textBoxSifra.Name = "textBoxSifra";
            textBoxSifra.PasswordChar = '●';
            textBoxSifra.Size = new Size(158, 23);
            textBoxSifra.TabIndex = 8;
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.Font = new Font("Segoe UI", 9F);
            textBoxKorisnickoIme.Location = new Point(374, 79);
            textBoxKorisnickoIme.Margin = new Padding(3, 2, 3, 2);
            textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size = new Size(158, 23);
            textBoxKorisnickoIme.TabIndex = 7;
            // 
            // buttonDodajZaposlenika
            // 
            buttonDodajZaposlenika.BackColor = Color.ForestGreen;
            buttonDodajZaposlenika.FlatStyle = FlatStyle.Flat;
            buttonDodajZaposlenika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDodajZaposlenika.ForeColor = Color.White;
            buttonDodajZaposlenika.Location = new Point(374, 140);
            buttonDodajZaposlenika.Margin = new Padding(3, 2, 3, 2);
            buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            buttonDodajZaposlenika.Size = new Size(158, 30);
            buttonDodajZaposlenika.TabIndex = 9;
            buttonDodajZaposlenika.Text = "Dodaj zaposlenika";
            buttonDodajZaposlenika.UseVisualStyleBackColor = false;
            buttonDodajZaposlenika.Click += buttonDodajZaposlenika_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(24, 104);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(30, 79);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(21, 54);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(46, 29);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "Ime:";
            // 
            // textBoxIme
            // 
            textBoxIme.Font = new Font("Segoe UI", 9F);
            textBoxIme.Location = new Point(83, 27);
            textBoxIme.Margin = new Padding(3, 2, 3, 2);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(158, 23);
            textBoxIme.TabIndex = 1;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Font = new Font("Segoe UI", 9F);
            textBoxTelefon.Location = new Point(83, 101);
            textBoxTelefon.Margin = new Padding(3, 2, 3, 2);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(158, 23);
            textBoxTelefon.TabIndex = 4;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Font = new Font("Segoe UI", 9F);
            textBoxPrezime.Location = new Point(83, 52);
            textBoxPrezime.Margin = new Padding(3, 2, 3, 2);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(158, 23);
            textBoxPrezime.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 9F);
            textBoxMail.Location = new Point(83, 76);
            textBoxMail.Margin = new Padding(3, 2, 3, 2);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(158, 23);
            textBoxMail.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(565, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENIToolStripMenuItem
            // 
            mENIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { licniPodaciToolStripMenuItem, odjaviSeToolStripMenuItem });
            mENIToolStripMenuItem.Name = "mENIToolStripMenuItem";
            mENIToolStripMenuItem.Size = new Size(48, 20);
            mENIToolStripMenuItem.Text = "MENI";
            // 
            // licniPodaciToolStripMenuItem
            // 
            licniPodaciToolStripMenuItem.Name = "licniPodaciToolStripMenuItem";
            licniPodaciToolStripMenuItem.Size = new Size(252, 22);
            licniPodaciToolStripMenuItem.Text = "Lični podaci - ažuriranje podataka";
            licniPodaciToolStripMenuItem.Click += licniPodaciToolStripMenuItem_Click;
            // 
            // odjaviSeToolStripMenuItem
            // 
            odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            odjaviSeToolStripMenuItem.Size = new Size(252, 22);
            odjaviSeToolStripMenuItem.Text = "Odjavi se";
            odjaviSeToolStripMenuItem.Click += odjaviSeToolStripMenuItem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 215);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 4;
            label9.Text = "Izbriši korisnika";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 259);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 5;
            label10.Text = "ID zaposlenika:";
            // 
            // textboxobriši
            // 
            textboxobriši.Location = new Point(104, 256);
            textboxobriši.Name = "textboxobriši";
            textboxobriši.Size = new Size(100, 23);
            textboxobriši.TabIndex = 6;
            // 
            // obriši
            // 
            obriši.BackColor = Color.Red;
            obriši.ForeColor = SystemColors.ControlLightLight;
            obriši.Location = new Point(385, 256);
            obriši.Name = "obriši";
            obriši.Size = new Size(158, 28);
            obriši.TabIndex = 7;
            obriši.Text = "izbriši";
            obriši.UseVisualStyleBackColor = false;
            obriši.Click += obriši_Click;
            // 
            // Form_Dodaj_Zapos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 420);
            Controls.Add(obriši);
            Controls.Add(textboxobriši);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Dodaj_Zapos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj zaposlenika";
            FormClosed += Form_Dodaj_Zapos_FormClosed;
            Load += Form_Dodaj_Zaposlenika_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDodajZaposlenika;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxIme;
        private TextBox textBoxTelefon;
        private TextBox textBoxPrezime;
        private TextBox textBoxMail;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENIToolStripMenuItem;
        private ToolStripMenuItem licniPodaciToolStripMenuItem;
        private ToolStripMenuItem odjaviSeToolStripMenuItem;
        private Label label7;
        private Label label8;
        private TextBox textBoxSifra;
        private TextBox textBoxKorisnickoIme;
        private Label label6;
        private Label label1;
        private ComboBox comboBoxPosao;
        private DateTimePicker dateTimePickerDatum;
        private Label label9;
        private Label label10;
        private TextBox textboxobriši;
        private Button obriši;
    }
}