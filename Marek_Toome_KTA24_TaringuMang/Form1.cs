using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marek_Toome_KTA24_TaringuMang
{
    public partial class MT_Form1 : Form
    {
        public MT_Form1()
        {
            InitializeComponent();
            MT_JukuMangib.Enabled = false;
            MT_MangibPeeter.Enabled = false;
        }
        private void MT_AlustaMangu_Click(object sender, EventArgs e)
        {
            MT_Juku1Taring.Text = "";
            MT_Juku2Taring.Text = "";
            MT_JukuSumma.Text = "";
            MT_Peeter1Taring.Text = "";
            MT_Peeter2Taring.Text = "";
            MT_PeeterSumma.Text = "";
            MT_Voitja.Text = "";
            MT_JukuMangib.Enabled = true;
            MT_AlustaMangu.Enabled = false;
        }
        private void MT_JukuMangib_Click(object sender, EventArgs e)
        {
            MT_MangibPeeter.Enabled = false;
            int j1; // juhuslik arv
            int j2; // juhuslik arv
            Random rnd = new Random(); // juhusliku arvu genereerimine
            j1 = rnd.Next(1, 7);
            j2 = rnd.Next(1, 7);
            MT_Juku1Taring.Text = j1.ToString();
            MT_Juku2Taring.Text = j2.ToString();
            MT_JukuSumma.Text = (j1 + j2).ToString();
            MT_JukuMangib.Enabled = false;
            MT_MangibPeeter.Enabled = true;

        }

        private void MT_MangibPeeter_Click(object sender, EventArgs e)
        {
            int p1; // juhuslik arv
            int p2; // juhuslik arv
            Random rnd = new Random(); // juhusliku arvu genereerimine
            p1 = rnd.Next(1, 7);
            p2 = rnd.Next(1, 7);
            MT_Peeter1Taring.Text = p1.ToString();
            MT_Peeter2Taring.Text = p2.ToString();
            MT_PeeterSumma.Text = (p1 + p2).ToString();
            MT_MangibPeeter.Enabled = false;
            MT_AlustaMangu.Enabled = true;

            if (int.Parse(MT_JukuSumma.Text) > int.Parse(MT_PeeterSumma.Text))
            {
                MT_Voitja.Text = "Juku";
            }
            else if (int.Parse(MT_JukuSumma.Text) < int.Parse(MT_PeeterSumma.Text))
            {
                MT_Voitja.Text = "Peeter";
            }
            else
            {
                MT_Voitja.Text = "Viik";
            }
        }


    }
}
