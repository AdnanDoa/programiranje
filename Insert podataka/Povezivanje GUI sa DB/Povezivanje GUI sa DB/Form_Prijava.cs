using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Povezivanje_GUI_sa_DB
{
    public partial class Form_Prijava : Form
    {
        public Form_Prijava()
        {
            InitializeComponent();
        }

        // varijabla u kojoj će se spremati ID logovanog korisnika 
        // čiji podatak će se koristiti i u drugim formama
        public static String employeeID = "";

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            try
            {
                String korisnickoIme = textBoxKorisnickoIme.Text;
                String sifra = textBoxSifra.Text;

                String upit = "SELECT passwd, CONCAT(first_name, ' ', last_name), " +
                    "employee_id, login_status FROM employees " +
                    "WHERE username ='" + korisnickoIme + "' ";

                DBKonekcija konekcija = new DBKonekcija();
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());

                MySqlDataReader reader;

                reader = cmd.ExecuteReader();

                reader.Read();

                if (!reader.HasRows)
                    errorProvider.SetError(textBoxKorisnickoIme, "Pogrešno korisničko ime");
                else
                {
                    String passwd = reader[0].ToString();
                    String imePrez = reader[1].ToString();
                    employeeID = reader.GetValue(2).ToString();
                    String loginStatus = reader[3].ToString();

                    if (loginStatus == "1")
                    {
                        errorProvider.SetError(buttonPrijaviSe, "Korisnik je već prijavljen");
                    }
                    else if (sifra == passwd)
                    {
                        Form_Licni_Podaci frmLicPod = new Form_Licni_Podaci();
                        PostaviLoginStatus();
                        this.Hide();
                        frmLicPod.Show();
                    }
                    else
                        errorProvider.SetError(textBoxSifra, "Pogrešna šifra");
                }

                reader.Close();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PostaviLoginStatus()
        {
            try
            {
                String upit = "UPDATE employees SET login_status=1 " +
                    " WHERE employee_id='" + employeeID + "' ";

                DBKonekcija konekcija = new DBKonekcija();
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                cmd.ExecuteNonQuery();

                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PostaviLogoutStatus()
        {
            try
            {
                String upit = "UPDATE employees SET login_status=0 " +
                    " WHERE employee_id='" + employeeID + "' ";

                DBKonekcija konekcija = new DBKonekcija();
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                cmd.ExecuteNonQuery();

                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Prijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}