using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projektni_zadatak
{
    public partial class Form_Admin_Glavna : Form
    {
        DBKonekcija db = new DBKonekcija();

        public Form_Admin_Glavna()
        {
            InitializeComponent();
            PrikaziSveNarudzbe();
        }

        private void PrikaziSveNarudzbe()
        {
            try
            {
                string upit = @"SELECT n.narudzbenica_id, 
                                       CONCAT(k.ime, ' ', k.prezime) AS kupac, 
                                       n.datum_narudzbe
                                FROM NARUDZBENICA n
                                INNER JOIN KUPAC k ON n.kupac_id = k.kupac_id
                                ORDER BY n.datum_narudzbe DESC";

                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewNarudzbe.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewNarudzbe.Rows.Add(
                        reader["narudzbenica_id"].ToString(),
                        reader["kupac"].ToString(),
                        Convert.ToDateTime(reader["datum_narudzbe"]).ToString("dd.MM.yyyy")
                    );
                }

                reader.Close();
                db.ZatvoriKonekciju();

                if (DataGridViewNarudzbe.Rows.Count == 0)
                {
                    MessageBox.Show("Nema evidentiranih narudžbi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

       
        private void ObrisiNarudzbu()
        {
            if (DataGridViewNarudzbe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite narudžbu za brisanje!");
                return;
            }

            string narudzbaID = DataGridViewNarudzbe.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult odgovor = MessageBox.Show("Da li ste sigurni da želite obrisati narudžbu " + narudzbaID + " i sve njene stavke?",
                                                    "Potvrda brisanja",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (odgovor == DialogResult.Yes)
            {
                try
                {
                    db.OtvoriKonekciju();

                   
                    string brisanjeStavki = "DELETE FROM STAVKA_NARUDZBENICE WHERE narudzbenica_id = @id";
                    MySqlCommand cmdStavke = new MySqlCommand(brisanjeStavki, db.OtvoriKonekciju());
                    cmdStavke.Parameters.AddWithValue("@id", narudzbaID);
                    cmdStavke.ExecuteNonQuery();

                   
                    string brisanjeNarudzbe = "DELETE FROM NARUDZBENICA WHERE narudzbenica_id = @id";
                    MySqlCommand cmdNarudzba = new MySqlCommand(brisanjeNarudzbe, db.OtvoriKonekciju());
                    cmdNarudzba.Parameters.AddWithValue("@id", narudzbaID);
                    int redova = cmdNarudzba.ExecuteNonQuery();

                    if (redova > 0)
                    {
                        MessageBox.Show("Narudžba " + narudzbaID + " je uspješno obrisana.");
                        PrikaziSveNarudzbe(); 
                    }
                    else
                    {
                        MessageBox.Show("Narudžba nije pronađena!");
                    }

                    db.ZatvoriKonekciju();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju: " + ex.Message);
                }
            }
        }

      
        private void buttonOsvezi_Click(object sender, EventArgs e)
        {
            PrikaziSveNarudzbe();
        }

        
        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            ObrisiNarudzbu();
        }
    }
}
