using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Povezivanje_GUI_sa_DB
{
    public partial class Form_Licni_Podaci : Form
    {
        public Form_Licni_Podaci()
        {
            InitializeComponent();
        }

        DBKonekcija konekcija = new DBKonekcija();
        String empID = Form_Prijava.employeeID;
        Form_Prijava frmPrijava = new Form_Prijava();
        Form_Dodaj_Zapos frmDodajZap = new Form_Dodaj_Zapos();
        private void Form_Licni_Podaci_Load(object sender, EventArgs e)
        {
            PrikazPodataka();
        }

        private void PrikazPodataka()
        {
            String upit = "SELECT first_name, last_name, email, phone_number, " +
                "salary FROM employees WHERE employee_id ='" + empID + "' ";
            try
            {
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                textBoxID.Text = empID;
                textBoxIme.Text = reader[0].ToString();
                textBoxPrezime.Text = reader[1].ToString();
                textBoxMail.Text = reader[2].ToString();
                textBoxTelefon.Text = reader[3].ToString();
                textBoxPlata.Text = reader[4].ToString();

                reader.Close();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void AzuriranjePodataka()
        {
            try
            {
                String upit = "UPDATE employees SET " +
                    " first_name= '" + textBoxIme.Text + "', " +
                    " last_name='" + textBoxPrezime.Text + "', " +
                    " email='" + textBoxMail.Text + "', " +
                    " phone_number='" + textBoxTelefon.Text + "', " +
                    " salary='" + textBoxPlata.Text + "' " +
                    " WHERE employee_id='" + empID + "' ";

                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Podaci za ID=" + empID + " su ažurirani");

                konekcija.ZatvoriKonekciju();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            AzuriranjePodataka();
        }

        private void buttonOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrijava.PostaviLogoutStatus();
            frmPrijava.Show();
        }

        private void Form_Licni_Podaci_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrijava.PostaviLogoutStatus();
            Application.Exit();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrijava.PostaviLogoutStatus();
            frmPrijava.Show();
        }

        private void dodajZaposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDodajZap.Show();
        }
    }
}