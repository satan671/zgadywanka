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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
            label1.Text = "Historia Gry:\n";
            foreach (object historia in g.Historia)
                label1.Text += Convert.ToString(historia) + "\n";
        }
    }
}
