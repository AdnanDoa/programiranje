namespace Povezivanje_GUI_sa_DB
{
    partial class Form_Licni_Podaci
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
            buttonOdjaviSe = new Button();
            groupBox1 = new GroupBox();
            buttonIzmijeniPodatke = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPlata = new TextBox();
            textBoxID = new TextBox();
            textBoxIme = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxMail = new TextBox();
            menuStrip1 = new MenuStrip();
            mENIToolStripMenuItem = new ToolStripMenuItem();
            dodajZaposToolStripMenuItem = new ToolStripMenuItem();
            odjaviSeToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOdjaviSe
            // 
            buttonOdjaviSe.BackColor = Color.Crimson;
            buttonOdjaviSe.FlatStyle = FlatStyle.Flat;
            buttonOdjaviSe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOdjaviSe.ForeColor = Color.White;
            buttonOdjaviSe.Location = new Point(200, 363);
            buttonOdjaviSe.Name = "buttonOdjaviSe";
            buttonOdjaviSe.Size = new Size(100, 40);
            buttonOdjaviSe.TabIndex = 10;
            buttonOdjaviSe.Text = "Odjavi se";
            buttonOdjaviSe.UseVisualStyleBackColor = false;
            buttonOdjaviSe.Click += buttonOdjaviSe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonIzmijeniPodatke);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPlata);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxIme);
            groupBox1.Controls.Add(textBoxTelefon);
            groupBox1.Controls.Add(textBoxPrezime);
            groupBox1.Controls.Add(textBoxMail);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 313);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lični podaci";
            // 
            // buttonIzmijeniPodatke
            // 
            buttonIzmijeniPodatke.BackColor = Color.ForestGreen;
            buttonIzmijeniPodatke.FlatStyle = FlatStyle.Flat;
            buttonIzmijeniPodatke.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonIzmijeniPodatke.ForeColor = Color.White;
            buttonIzmijeniPodatke.Location = new Point(94, 267);
            buttonIzmijeniPodatke.Name = "buttonIzmijeniPodatke";
            buttonIzmijeniPodatke.Size = new Size(180, 40);
            buttonIzmijeniPodatke.TabIndex = 6;
            buttonIzmijeniPodatke.Text = "Izmijeni podatke";
            buttonIzmijeniPodatke.UseVisualStyleBackColor = false;
            buttonIzmijeniPodatke.Click += buttonIzmijeniPodatke_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(43, 209);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 11;
            label6.Text = "Plata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(27, 176);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(33, 143);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(23, 110);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(51, 77);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 7;
            label2.Text = "Ime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 6;
            label1.Text = "ID:";
            // 
            // textBoxPlata
            // 
            textBoxPlata.Font = new Font("Segoe UI", 9F);
            textBoxPlata.Location = new Point(94, 206);
            textBoxPlata.Name = "textBoxPlata";
            textBoxPlata.Size = new Size(180, 27);
            textBoxPlata.TabIndex = 5;
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Segoe UI", 9F);
            textBoxID.Location = new Point(94, 41);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(90, 27);
            textBoxID.TabIndex = 0;
            textBoxID.TabStop = false;
            // 
            // textBoxIme
            // 
            textBoxIme.Font = new Font("Segoe UI", 9F);
            textBoxIme.Location = new Point(94, 74);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(180, 27);
            textBoxIme.TabIndex = 1;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Font = new Font("Segoe UI", 9F);
            textBoxTelefon.Location = new Point(94, 173);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(180, 27);
            textBoxTelefon.TabIndex = 4;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Font = new Font("Segoe UI", 9F);
            textBoxPrezime.Location = new Point(94, 107);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(180, 27);
            textBoxPrezime.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 9F);
            textBoxMail.Location = new Point(94, 140);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(180, 27);
            textBoxMail.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(312, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENIToolStripMenuItem
            // 
            mENIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajZaposToolStripMenuItem, odjaviSeToolStripMenuItem });
            mENIToolStripMenuItem.Name = "mENIToolStripMenuItem";
            mENIToolStripMenuItem.Size = new Size(59, 24);
            mENIToolStripMenuItem.Text = "MENI";
            // 
            // dodajZaposToolStripMenuItem
            // 
            dodajZaposToolStripMenuItem.Name = "dodajZaposToolStripMenuItem";
            dodajZaposToolStripMenuItem.Size = new Size(224, 26);
            dodajZaposToolStripMenuItem.Text = "Dodaj zaposlenika";
            dodajZaposToolStripMenuItem.Click += dodajZaposToolStripMenuItem_Click;
            // 
            // odjaviSeToolStripMenuItem
            // 
            odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            odjaviSeToolStripMenuItem.Size = new Size(224, 26);
            odjaviSeToolStripMenuItem.Text = "Odjavi se";
            odjaviSeToolStripMenuItem.Click += odjaviSeToolStripMenuItem_Click;
            // 
            // Form_Licni_Podaci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 413);
            Controls.Add(groupBox1);
            Controls.Add(buttonOdjaviSe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Licni_Podaci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lični podaci";
            FormClosed += Form_Licni_Podaci_FormClosed;
            Load += Form_Licni_Podaci_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOdjaviSe;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxPlata;
        private TextBox textBoxID;
        private TextBox textBoxIme;
        private TextBox textBoxTelefon;
        private TextBox textBoxPrezime;
        private TextBox textBoxMail;
        private Label label4;
        private Label label3;
        private Button buttonIzmijeniPodatke;
        private Label label6;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENIToolStripMenuItem;
        private ToolStripMenuItem dodajZaposToolStripMenuItem;
        private ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}