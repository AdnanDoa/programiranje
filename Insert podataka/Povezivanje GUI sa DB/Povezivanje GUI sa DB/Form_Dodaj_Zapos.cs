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
    public partial class Form_Dodaj_Zapos : Form
    {
        public Form_Dodaj_Zapos()
        {
            InitializeComponent();
        }

        private void Form_Dodaj_Zaposlenika_Load(object sender, EventArgs e)
        {
            PopuniComboBoxPosao();
        }

        DBKonekcija konekcija = new DBKonekcija();
        Form_Prijava frmPrijava = new Form_Prijava();

        private void DodajZaposlenika()
        {
            try
            {
                String upit = "INSERT INTO employees(first_name, last_name, email, " +
                    " phone_number, hire_date, job_id, username, passwd, login_status) " +
                    " VALUES('" + textBoxIme.Text + "', '" + textBoxPrezime.Text + "', " +
                    " '" + textBoxMail.Text + "', '" + textBoxTelefon.Text + "', " +
                    " '" + dateTimePickerDatum.Value.ToString("yyyy-MM-dd") + "', " +
                    " '" + comboBoxPosao.Text + "', '" + textBoxKorisnickoIme.Text + "', " +
                    " '" + textBoxSifra.Text + "', 0) ";

                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Dodan novi korisnik");

                konekcija.ZatvoriKonekciju();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void PopuniComboBoxPosao()
        {
            try
            {
                String upit = "SELECT job_id FROM jobs";

                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxPosao.Items.Add(reader["job_id"].ToString());
                }
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenika();
        }

        private void licniPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Licni_Podaci frmLicPod = new Form_Licni_Podaci();
            this.Hide();
            frmLicPod.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrijava.PostaviLogoutStatus();
            frmPrijava.Show();
        }

        private void Form_Dodaj_Zapos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrijava.PostaviLogoutStatus();
            Application.Exit();
        }

        private void obriši_Click(object sender, EventArgs e)
        {
           
            try
            {

                String upit = "delete " + "from employees " + "where employee_id='" + textboxobriši.Text + "'";
                     


                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("izbrisan korisnik");

                konekcija.ZatvoriKonekciju();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
    }
}