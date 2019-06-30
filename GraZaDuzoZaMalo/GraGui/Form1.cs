using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGui
{
    public partial class Form1 : Form
    {
        private Gra g;
        private DateTime CzasStart;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxLosowanie_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            panel_sprawdz.Visible = false;
            panel_odpowiedz.Visible = false;
            Sprawdz.Enabled = true;
            buttonLosuj.Enabled = true;
            Odpowiedz.Visible = false;
            textBoxSprawdzana.Text = null;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            CzasStart = DateTime.Now;
            //try-catch
            int zakresOd = int.Parse(textBoxZakresOd.Text);
            int zakresDo = int.Parse(textBoxZakresDo.Text);
            g = new Gra(zakresOd, zakresDo);
            panel_sprawdz.Visible = true;
            Przerwij.Enabled = true;
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            int sprawdzana2 = int.Parse(textBoxSprawdzana.Text);
            Odpowiedz.Text = Convert.ToString(g.Ocena(sprawdzana2));
            if ((Odpowiedz.Text == "ZaDużo")|| (Odpowiedz.Text == "ZaMało"))
                Odpowiedz.ForeColor = Color.Red;
            else
            {
                Odpowiedz.ForeColor = Color.Green;
                Koniec_gry();
            }
            Odpowiedz.Visible = true;
        }

        private void TextBoxZakresOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Przerwij_Click(object sender, EventArgs e)
        {
            Odpowiedz.Text = "Poddana";
            Odpowiedz.ForeColor = Color.Red;
            Odpowiedz.Visible = true;
            g.Poddaj();
            Koniec_gry();
        }

        public void Koniec_gry()
        {
            Wylosowana.Text = $"Wylosowana: {g.CoBylWylosowane()}";
            Liczba_ruchow.Text = $"Liczba ruchów: {g.LicznikRuchow}";
            Laczny_czas_gry.Text = $"Łączny czas gry: {g.LicznikCzasu(CzasStart)}";
            panel_odpowiedz.Visible = true;
            Przerwij.Enabled = false;
            Sprawdz.Enabled = false;
            buttonLosuj.Enabled = false;
        }

        private void Historia_Click(object sender, EventArgs e)
        {

        }

    }
}
