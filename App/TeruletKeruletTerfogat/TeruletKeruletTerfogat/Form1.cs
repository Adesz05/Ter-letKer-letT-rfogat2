using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeruletKeruletTerfogat
{
    public partial class Form1 : Form
    {
        static string Aktkep = "Háromszög.png";
        static List<Poziciok> Pozik = new List<Poziciok>();

        static double a = 0;
        static double b = 0;
        static double c = 0;
        static double d = 0;
        static double e = 0;
        static double f = 0;
        static double ma = 0;
        static double m = 0;
        static double r = 0;
        static double kerulet = 0;
        static double terulet = 0;
        static double terfogat = 0;
        static double felszin = 0;
        static string alakzat = "";
        

        public Form1()
        {
            InitializeComponent();
            PozicioFeltoltes();
            Torles();
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            aOldalMagassagLathato(3);
        }

        private void PozicioFeltoltes()
        {
            for (int i = 0; i < 9; i++)
            {
                Pozik.Add(new Poziciok(new Koordinatak(8, 24+35*i), new Koordinatak(84, 22+35*i), new Koordinatak(192, 21+35*i)));
            }
        }

        private void aOldalNemLathato()
        {
            aOldal.Visible = false;
            aOldalTextBox.Visible = false;
            aOldalTextBox.Text= "";
            aOldalMertekegyseg.Visible = false;

        }
        private void aOldalLathato(int index)
        {
            aOldal.Visible = true;
            aOldalTextBox.Visible = true;
            aOldalMertekegyseg.Visible = true;
            aOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            aOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            aOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }
        private void dOldalNemLathato()
        {
            dOldal.Visible = false;
            dOldalTextBox.Visible = false;
            dOldalMertekegyseg.Visible = false;
            dOldalTextBox.Text = "";
        }

        private void dOldalLathato(int index)
        {
            dOldal.Visible = true;
            dOldalTextBox.Visible = true;
            dOldalMertekegyseg.Visible = true;
            dOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            dOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            dOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }
        private void eOldalNemLathato()
        {
            eOldal.Visible = false;
            eOldalTextBox.Visible = false;
            eOldalMertekegyseg.Visible = false;
            eOldalTextBox.Text = "";
        }

        private void eOldalLathato(int index)
        {
            eOldal.Visible = true;
            eOldalTextBox.Visible = true;
            eOldalMertekegyseg.Visible = true;
            eOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            eOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            eOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }
        private void fOldalNemLathato()
        {
            fOldal.Visible = false;
            fOldalTextBox.Visible = false;
            fOldalMertekegyseg.Visible = false;
            fOldalTextBox.Text = "";
        }

        private void fOldalLathato(int index)
        {
            fOldal.Visible = true;
            fOldalTextBox.Visible = true;
            fOldalMertekegyseg.Visible = true;
            fOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            fOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            fOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }
        private void mOldalNemLathato()
        {
            mOldal.Visible = false;
            mOldalTextBox.Visible = false;
            mOldalMertekegyseg.Visible = false;
            mOldalTextBox.Text = "";
        }

        private void mOldalLathato(int index)
        {
            mOldal.Visible = true;
            mOldalTextBox.Visible = true;
            mOldalMertekegyseg.Visible = true;
            mOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            mOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            mOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }
        private void rSugarNemLathato()
        {
            rSugar.Visible = false;
            rSugarTextBox.Visible = false;
            rSugarMertekegyseg.Visible = false;
            rSugarTextBox.Text = "";
        }

        private void rSugarLathato(int index)
        {
            rSugar.Visible = true;
            rSugarTextBox.Visible = true;
            rSugarMertekegyseg.Visible = true;
            rSugar.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            rSugarTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            rSugarMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }

        private void Torles()
        {
            aOldalNemLathato();
            bOldalNemLathato();
            cOldalNemLathato();
            dOldalNemLathato();
            eOldalNemLathato();
            fOldalNemLathato();
            rSugarNemLathato();
            mOldalNemLathato();
            aOldalMagassagNemLathato();

        }

        private void aOldalMagassagNemLathato()
        {
            aOldalMagassag.Visible = false;
            aOldalMagassagTextBox.Visible = false;
            aOldalMagassagMertekegyseg.Visible = false;
            aOldalMagassagTextBox.Text = "";
        }
        private void bOldalNemLathato()
        {
            bOldal.Visible = false;
            bOldalTextBox.Visible = false;
            bOldalMertekegyseg.Visible = false;
            bOldalTextBox.Text = "";
        }
        private void cOldalNemLathato()
        {
            cOldal.Visible = false;
            cOldalTextBox.Visible = false;
            cOldalMertekegyseg.Visible = false;
            cOldalTextBox.Text = "";
        }

        private void aOldalMagassagLathato(int index)
        {
            aOldalMagassag.Visible = true;
            aOldalMagassagTextBox.Visible = true;
            aOldalMagassagMertekegyseg.Visible = true;
            aOldalMagassag.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            aOldalMagassagTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            aOldalMagassagMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }

        private void cOldalLathato(int index)
        {
            cOldal.Visible = true;
            cOldalTextBox.Visible = true;
            cOldalMertekegyseg.Visible = true;
            cOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            cOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            cOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }

        private void bOldalLathato(int index)
        {
            bOldal.Visible = true;
            bOldalTextBox.Visible = true;
            bOldalMertekegyseg.Visible = true;
            bOldal.Location = new Point(Pozik[index].Label.X, Pozik[index].Label.Y);
            bOldalTextBox.Location = new Point(Pozik[index].TextBox.X, Pozik[index].TextBox.Y);
            bOldalMertekegyseg.Location = new Point(Pozik[index].ComboBox.X, Pozik[index].ComboBox.Y);
        }

        private void haromszogGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Háromszög.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            aOldalMagassagLathato(3);

            
        }

        private void HaromszogSzamitas()
        {
            double hterulet = 0;
            double hkerulet = 0;

            if (aOldalTextBox.Text != "" && bOldalTextBox.Text != "" && cOldalTextBox.Text != "" && aOldalMagassag.Text != "")
            {
                 a = Convert.ToDouble(aOldalTextBox.Text);
                 b = Convert.ToDouble(bOldalTextBox.Text);
                 c = Convert.ToDouble(cOldalTextBox.Text);
                 ma = Convert.ToDouble(aOldalMagassagTextBox.Text);

                terulet = a + b + c;
                kerulet = (a * ma) / 2;

                label3.Text = "K = " + terulet.ToString();
                label4.Text = "T = " + kerulet.ToString();
            }
        }

        private void trapezGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Trapéz.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            dOldalLathato(3);
            aOldalMagassagLathato(4);
        }

        private void paralelogrammaGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Paralelogramma.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            aOldalMagassagLathato(2);
        }

        private void teglalapGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Téglalap.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
        }

        private void deltoidGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Deltoid.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            eOldalLathato(2);
            fOldalLathato(3);

        }

        private void rombuszGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Rombusz.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            eOldalLathato(1);
            fOldalLathato(2);
        }

        private void negyzetGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Négyzet.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
        }

        private void korGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Kör.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            rSugarLathato(0);
        }

        private void gombGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Gömb.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            rSugarLathato(0);
        }

        private void hengerGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Henger.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            mOldalLathato(0);
            rSugarLathato(1);
        }

        private void gulaGomb_Click(object sender, EventArgs e)
        {
            Aktkep = "Gúla.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            aOldalLathato(0);
            mOldalLathato(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //HaromszogSzamitas();
            //NegyzetSzamitas();
            //KorSzamitas();
            //GombSzamitas();
            //HengerSzamitas();
            //GulaSzamitas();
        }

        private void GulaSzamitas()
        {
            a = Convert.ToDouble(aOldalTextBox.Text);
            m = Convert.ToDouble(mOldalTextBox.Text);
            ma = Math.Sqrt(a * a + m * m);

            felszin = (a * a + 4 * a * ma)/2;
            terfogat = (a*a*m)/3;

            label3.Text = "F = " + felszin.ToString();
            label4.Text = "V = " + terfogat.ToString();
        }

        private void HengerSzamitas()
        {
            r = Convert.ToDouble(rSugarTextBox.Text);
            m = Convert.ToDouble(mOldalTextBox.Text);


            felszin = 2 * r * r * Math.PI + 2 * r * m * Math.PI;
            terfogat = r * r * Math.PI * m;

            label3.Text = "F = " + felszin.ToString();
            label4.Text = "V = " + terfogat.ToString();
        }

        private void GombSzamitas()
        {
            r = Convert.ToDouble(rSugarTextBox.Text);

            felszin = 4 *r* r * Math.PI;
            terfogat = (4*r*r*r*Math.PI)/3;

            label3.Text = "F = " + felszin.ToString();
            label4.Text = "V = " + terfogat.ToString();
        }

        private void KorSzamitas()
        {
            r = Convert.ToDouble(rSugarTextBox.Text);

            kerulet = 2*r*Math.PI;
            terulet = r*r*Math.PI;

            label3.Text = "K = " + kerulet.ToString();
            label4.Text = "T = " + terulet.ToString();
        }

        private void NegyzetSzamitas()
        {
            a = Convert.ToDouble(aOldalTextBox.Text);

            kerulet = a * 4;
            terulet = a * a;

            label3.Text = "K = " + kerulet.ToString();
            label4.Text = "T = " + terulet.ToString();
        }

        private void aOldalTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length==1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Aoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Aoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }


        }

        private void bOldalTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Boldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Boldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
                
        }

        private void cOldalTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Coldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Coldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void dOldalTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Doldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Doldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void aOldalMagassagTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Magassagoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Magassagoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void rSugarTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Rsugár.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Rsugár.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void eOldalTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
