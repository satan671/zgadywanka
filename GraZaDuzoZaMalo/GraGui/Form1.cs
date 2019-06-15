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
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {   
            //try-catch
            int zakresOd = int.Parse(textBoxZakresOd.Text);
            int zakresDo = int.Parse(textBoxZakresDo.Text);
            g = new Gra(zakresOd, zakresDo);
            panel_sprawdz.Visible = true;
            Przerwij.Enabled = true;

        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxZakresOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Przerwij_Click(object sender, EventArgs e)
        {
            g.Poddaj();
            Wylosowana.Text = $"Wylosowana: {g.CoBylWylosowane()}";
            Liczba_ruchow.Text = $"Liczba ruchów: {g.LicznikRuchow}";
            Laczny_czas_gry.Text = $"Łączny czas gry: "; // do zrobienia timer
            panel_odpowiedz.Visible = true;

        }

        private void Historia_Click(object sender, EventArgs e)
        {

        }

    }
}
