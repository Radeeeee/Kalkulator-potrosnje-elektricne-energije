using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalkulatorPotrosnjeElektricneEnergije
{
    public partial class formPodesavanja : Form
    {
        public formPodesavanja()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.mechanical_gears_1;

            ucitajPodatke();
        }

        // Metoda koja popunjava sva polja odgovarajucim podacima koje je korisnik vec podesio
        private void ucitajPodatke()
        {

            try
            {
                txtBoxCijenaPotrosnjeNT.Text = Properties.Settings.Default.CijenaPotrosnjeNizaTarifaLJ.ToString();
                txtBoxCijenaPotrosnjeVT.Text = Properties.Settings.Default.CijenaPotrosnjeVisaTarifaLJ.ToString();
                txtBoxCijenaPotrosnjeST.Text = Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaLJ.ToString();
                txtBoxCijenaPotrosnjeNTZ.Text = Properties.Settings.Default.CijenaPotrosnjeNizaTarifaZ.ToString();
                txtBoxCijenaPotrosnjeVTZ.Text = Properties.Settings.Default.CijenaPotrosnjeVisaTarifaZ.ToString();
                txtBoxCijenaPotrosnjeSTZ.Text = Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaZ.ToString();
                txtBoxCijenaJednotarifnoBrojilo.Text = Properties.Settings.Default.PretplataJednotarifnoBrojilo.ToString();
                txtBoxCijenaDvotarifnoBrojilo.Text = Properties.Settings.Default.PretplataDvotarifnoBrojilo.ToString();
                txtBoxNaknadaUslugaSnabdjevanja.Text = Properties.Settings.Default.NaknadaUslugaSnabdjevanja.ToString();
                txtBoxNaknadaObnovljiviIzvori.Text = Properties.Settings.Default.NaknadaObnovljiviIzvori.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greška: " + ex.Message, "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Metoda koja omogucava izlaz iz prozora Podesavanja
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;

        }

        // Provjera koja omogucava da se u textbox kontrole unose samo brojevi i "."
        private void txtBoxCijenaPotrosnjeVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Dozvoliti samo jedno pojavljivanje "."
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Metoda koja omogucava cuvanje podataka nakon sto je korisnik izvrsio njihove promjene
        private void btnSacuvajPodatke_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CijenaPotrosnjeNizaTarifaLJ = Convert.ToDouble(txtBoxCijenaPotrosnjeNT.Text);
            Properties.Settings.Default.CijenaPotrosnjeVisaTarifaLJ = Convert.ToDouble(txtBoxCijenaPotrosnjeVT.Text);
            Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaLJ = Convert.ToDouble(txtBoxCijenaPotrosnjeST.Text);
            Properties.Settings.Default.CijenaPotrosnjeNizaTarifaZ = Convert.ToDouble(txtBoxCijenaPotrosnjeNTZ.Text);
            Properties.Settings.Default.CijenaPotrosnjeVisaTarifaZ = Convert.ToDouble(txtBoxCijenaPotrosnjeVTZ.Text);
            Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaZ = Convert.ToDouble(txtBoxCijenaPotrosnjeSTZ.Text);
            Properties.Settings.Default.PretplataJednotarifnoBrojilo = Convert.ToDouble(txtBoxCijenaJednotarifnoBrojilo.Text);
            Properties.Settings.Default.PretplataDvotarifnoBrojilo = Convert.ToDouble(txtBoxCijenaDvotarifnoBrojilo.Text);
            Properties.Settings.Default.NaknadaUslugaSnabdjevanja = Convert.ToDouble(txtBoxNaknadaUslugaSnabdjevanja.Text);
            Properties.Settings.Default.NaknadaObnovljiviIzvori = Convert.ToDouble(txtBoxNaknadaObnovljiviIzvori.Text);

            Properties.Settings.Default.Save();
            MessageBox.Show("Promjene su sačuvane.", "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
