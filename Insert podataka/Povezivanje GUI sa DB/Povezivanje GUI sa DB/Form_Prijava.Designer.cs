namespace Povezivanje_GUI_sa_DB
{
    partial class Form_Prijava
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
            components = new System.ComponentModel.Container();
            buttonPrijaviSe = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxKorisnickoIme = new TextBox();
            textBoxSifra = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonPrijaviSe
            // 
            buttonPrijaviSe.BackColor = Color.Gold;
            buttonPrijaviSe.FlatStyle = FlatStyle.Flat;
            buttonPrijaviSe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrijaviSe.Location = new Point(455, 232);
            buttonPrijaviSe.Margin = new Padding(3, 2, 3, 2);
            buttonPrijaviSe.Name = "buttonPrijaviSe";
            buttonPrijaviSe.Size = new Size(82, 28);
            buttonPrijaviSe.TabIndex = 3;
            buttonPrijaviSe.Text = "PRIJAVA";
            buttonPrijaviSe.UseVisualStyleBackColor = false;
            buttonPrijaviSe.Click += buttonPrijaviSe_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.prijava;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(562, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox2.Image = Properties.Resources.setsLogo;
            pictureBox2.Location = new Point(177, 134);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 217, 217);
            label1.Location = new Point(279, 166);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(217, 217, 217);
            label2.Location = new Point(338, 191);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Šifra:";
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.BorderStyle = BorderStyle.FixedSingle;
            textBoxKorisnickoIme.Location = new Point(380, 165);
            textBoxKorisnickoIme.Margin = new Padding(3, 2, 3, 2);
            textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size = new Size(158, 23);
            textBoxKorisnickoIme.TabIndex = 1;
            // 
            // textBoxSifra
            // 
            textBoxSifra.BorderStyle = BorderStyle.FixedSingle;
            textBoxSifra.Location = new Point(380, 190);
            textBoxSifra.Margin = new Padding(3, 2, 3, 2);
            textBoxSifra.Name = "textBoxSifra";
            textBoxSifra.PasswordChar = '●';
            textBoxSifra.Size = new Size(158, 23);
            textBoxSifra.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider.ContainerControl = this;
            // 
            // Form_Prijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 331);
            Controls.Add(textBoxSifra);
            Controls.Add(textBoxKorisnickoIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPrijaviSe);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form_Prijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            FormClosed += Form_Prijava_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPrijaviSe;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox textBoxKorisnickoIme;
        private TextBox textBoxSifra;
        private ErrorProvider errorProvider;
    }
}
