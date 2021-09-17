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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.plug1;

            // Ispisivanje vremena i datuma pri pokretanju aplikacije
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");

        }

        // Metoda koja svake sekunde osvjezava labelu u kojoj se ispisuje datum i vrijeme
        private void timerClk_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
        }

        // Metoda koja omogucava izlaz iz aplikacije klikom na Izlaz opciju u Meniju
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Metoda koja omogucava ciscenje svih polja i vracanje aplikacije u pocetno stanje
        private void btnOcistiPolja_Click(object sender, EventArgs e)
        {
            comboBoxTarifnaGrupa.SelectedItem = null;
            txtBoxPotrosnjaVisaTarifa.Clear();
            txtBoxPotrosnjaNizaTarifa.Clear();
            comboBoxSezonaObracuna.SelectedItem = null;
        }

        // Provjera koja omogucava da se u textbox kontrole unose samo brojevi i "."
        private void txtBoxPotrosnjaVisaTarifa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            // Provjera da li su svi potrebni podaci uneseni
            if (comboBoxSezonaObracuna.SelectedIndex == -1 || comboBoxTarifnaGrupa.SelectedIndex == -1 || txtBoxPotrosnjaNizaTarifa.Text == "" || txtBoxPotrosnjaVisaTarifa.Text == "")
            {
                MessageBox.Show("Molimo Vas da unesite sve podatke!", "Kalkulator potrošnje električne energije - Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    // Provjera da li se radi o jednotarifnoj ili dvotarifnoj grupi
                    if (comboBoxTarifnaGrupa.SelectedIndex == 0) // 0 - jednotarifna grupa
                    {
                        double potrosnjaBrojila = izracunajPotrosnjuJednotarifnogBrojila();
                        double cijena = potrosnjaBrojila + Properties.Settings.Default.PretplataJednotarifnoBrojilo + Properties.Settings.Default.NaknadaUslugaSnabdjevanja + Properties.Settings.Default.NaknadaObnovljiviIzvori;
                        double cijenaSaPDV = cijena + (cijena * 0.17);
                        azurirajPolja(Properties.Settings.Default.PretplataJednotarifnoBrojilo, txtBoxPotrosnjaVisaTarifa.Text, txtBoxPotrosnjaNizaTarifa.Text, Properties.Settings.Default.NaknadaUslugaSnabdjevanja, Properties.Settings.Default.NaknadaObnovljiviIzvori, cijenaSaPDV);
                    }
                    else // 1 - dvotarifna grupa
                    {
                        double potrosnjaBrojila = izracunajPotrosnjuDvotarifnogBrojila();
                        double cijena = potrosnjaBrojila + Properties.Settings.Default.PretplataDvotarifnoBrojilo + Properties.Settings.Default.NaknadaUslugaSnabdjevanja + Properties.Settings.Default.NaknadaObnovljiviIzvori;
                        double cijenaSaPDV = cijena + (cijena * 0.17);
                        azurirajPolja(Properties.Settings.Default.PretplataDvotarifnoBrojilo, txtBoxPotrosnjaVisaTarifa.Text, txtBoxPotrosnjaNizaTarifa.Text, Properties.Settings.Default.NaknadaUslugaSnabdjevanja, Properties.Settings.Default.NaknadaObnovljiviIzvori, cijenaSaPDV);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Desila se greška: " + ex.Message, "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void podešavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formPod = new formPodesavanja();
            formPod.ShowDialog();

            if (formPod.DialogResult == System.Windows.Forms.DialogResult.OK || formPod.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Show();
            }
        }

        //Izraz za odredjivanje cijene(dvotarifno brojilo): Cijena = PotrosnjaVisaTarifa * cijenaVisaTarifa + PotrosnjaNizaTarifa * cijenaNizaTarifa

        private double izracunajPotrosnjuDvotarifnogBrojila()
        {
            try
            {



                // Obracun nize tarife
                if (comboBoxSezonaObracuna.SelectedIndex == 1)
                {
                    return Convert.ToDouble(txtBoxPotrosnjaVisaTarifa.Text) * Properties.Settings.Default.CijenaPotrosnjeVisaTarifaLJ
                    + Convert.ToDouble(txtBoxPotrosnjaNizaTarifa.Text) * Properties.Settings.Default.CijenaPotrosnjeNizaTarifaLJ;
                }
                // Obracun vise tarife
                else
                {
                    return Convert.ToDouble(txtBoxPotrosnjaVisaTarifa.Text) * Properties.Settings.Default.CijenaPotrosnjeVisaTarifaZ
                    + Convert.ToDouble(txtBoxPotrosnjaNizaTarifa.Text) * Properties.Settings.Default.CijenaPotrosnjeNizaTarifaZ;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Desila se greška: " + ex.Message, "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        // Cijena = (potrosnjaVisaTarifa + potrosnjaNizaTarifa) * cijenaSrednjaTarifa

        private double izracunajPotrosnjuJednotarifnogBrojila()
        {

            try
            {

                // Obracun nize tarife
                if (comboBoxSezonaObracuna.SelectedIndex == 1)
                {
                    return (Convert.ToDouble(txtBoxPotrosnjaVisaTarifa.Text) + Convert.ToDouble(txtBoxPotrosnjaNizaTarifa.Text)) * Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaLJ;
                }
                // Obracun vise tarife
                else
                {
                    return (Convert.ToDouble(txtBoxPotrosnjaVisaTarifa.Text) + Convert.ToDouble(txtBoxPotrosnjaNizaTarifa.Text)) * Properties.Settings.Default.CijenaPotrosnjeSrednjaTarifaZ;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Desila se greška: " + ex.Message, "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        // Metoda koja azurira polja nakon odredjenih proracuna
        private void azurirajPolja(double pretplata, string potrosnjaVT, string potrosnjaNT, double naknadaUslugaSnabdjevanja, double naknadaObnovljiviIzvori, double ukupnaCijena)
        {

            try
            {

                lblPretplataCijena.Text = pretplata.ToString("0.##") + " KM";
                if (comboBoxSezonaObracuna.SelectedIndex == 0)
                {
                    lblPotrosnjaVTCijena.Text = (Convert.ToDouble(potrosnjaVT) * Properties.Settings.Default.CijenaPotrosnjeVisaTarifaZ).ToString("0.##") + " KM";
                }
                else
                {
                    lblPotrosnjaVTCijena.Text = (Convert.ToDouble(potrosnjaVT) * Properties.Settings.Default.CijenaPotrosnjeVisaTarifaLJ).ToString("0.##") + " KM";
                }

                if (comboBoxSezonaObracuna.SelectedIndex == 0)
                {
                    lblPotrosnjaNTCijena.Text = (Convert.ToDouble(potrosnjaNT) * Properties.Settings.Default.CijenaPotrosnjeNizaTarifaZ).ToString("0.##") + " KM";
                }
                else
                {
                    lblPotrosnjaNTCijena.Text = (Convert.ToDouble(potrosnjaNT) * Properties.Settings.Default.CijenaPotrosnjeNizaTarifaLJ).ToString("0.##") + " KM";
                }

                lblNaknadaZaUSCijena.Text = naknadaUslugaSnabdjevanja.ToString("0.##") + " KM";
                lblNaknadaZaOICijena.Text = naknadaObnovljiviIzvori.ToString("0.##") + " KM";
                lblIznosRacuna.Text = ukupnaCijena.ToString("0.##") + " KM";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Desila se greška: " + ex.Message, "Kalkulator potrošnje električne energije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
