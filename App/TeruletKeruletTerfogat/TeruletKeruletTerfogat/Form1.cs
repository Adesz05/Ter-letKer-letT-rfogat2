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
        static string alakzat = "háromszög";
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

        private void aOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(aOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                aOldalTextBox.Text = aOldalTextBox.Text.Remove(aOldalTextBox.Text.Length - 1);
            }
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
            Sikidom();
            Aktkep = "Háromszög.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            aOldalMagassagLathato(3);
            alakzat = "háromszög";
        }

        private void Sikidom()
        {
            label3.Text = "K=?";
            label4.Text = "T=?";
        }
        private void Test()
        {
            label3.Text = "F=?";
            label4.Text = "V=?";
        }

        private void trapezGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Trapéz.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            dOldalLathato(3);
            aOldalMagassagLathato(4);
            alakzat = "trapéz";
        }

        private void paralelogrammaGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Paralelogramma.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            aOldalMagassagLathato(2);
            alakzat = "paralelogramma";
        }

        private void teglalapGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Téglalap.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            alakzat = "téglalap";
        }

        private void deltoidGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Deltoid.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            eOldalLathato(2);
            fOldalLathato(3);
            alakzat = "deltoid";
        }

        private void rombuszGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Rombusz.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            eOldalLathato(1);
            fOldalLathato(2);
            alakzat = "rombusz";
        }

        private void negyzetGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Négyzet.png";
            alakzatPictureBox.Image = Image.FromFile(Aktkep);
            Torles();
            aOldalLathato(0);
            alakzat = "négyzet";
        }

        private void korGomb_Click(object sender, EventArgs e)
        {
            Sikidom();
            Aktkep = "Kör.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            rSugarLathato(0);
            alakzat = "kör";
        }

        private void gombGomb_Click(object sender, EventArgs e)
        {
            Test();
            Aktkep = "Gömb.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            rSugarLathato(0);
            alakzat = "gömb";
        }

        private void hengerGomb_Click(object sender, EventArgs e)
        {
            Test();
            Aktkep = "Henger.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            mOldalLathato(0);
            rSugarLathato(1);
            alakzat = "henger";
        }

        private void gulaGomb_Click(object sender, EventArgs e)
        {
            Test();
            Aktkep = "Gúla.png";
            alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            Torles();
            aOldalLathato(0);
            mOldalLathato(1);
            alakzat = "gúla";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "háromszög":
                    HaromszogSzamitas();
                    break;
                case "kör":
                    KorSzamitas();
                    break;
                case "henger":
                    HengerSzamitas();
                    break;
                case "rombusz":
                    RombuszSzamitas();
                    break;
                case "téglalap":
                    TeglalapSzamitas();
                    break;
                case "gúla":
                    GulaSzamitas();
                    break;
                case "deltoid":
                    DeltoidSzamitas();
                    break;
                case "trapéz":
                    TrapezSzamitas();
                    break;
                case "négyzet":
                    NegyzetSzamitas();
                    break;
                case "gömb":
                    GombSzamitas();
                    break;
                case "paralelogramma":
                    ParalelogrammaSzamitas();
                    break;
            }
        }

        private void GulaSzamitas()
        {
            if (aOldalTextBox.Text!="" && mOldalTextBox.Text!="" && aOldalMagassagTextBox.Text!="")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                m = Convert.ToDouble(mOldalTextBox.Text);
                ma = Math.Sqrt(a * a + m * m);

                felszin = (a * a + 4 * a * ma) / 2;
                terfogat = (a * a * m) / 3;

                label3.Text = "F = " + felszin.ToString();
                label4.Text = "V = " + terfogat.ToString();
            }
        }

        private void HengerSzamitas()
        {
            if (rSugarTextBox.Text!="" && mOldalTextBox.Text!="")
            {
                r = Convert.ToDouble(rSugarTextBox.Text);
                m = Convert.ToDouble(mOldalTextBox.Text);


                felszin = 2 * r * r * Math.PI + 2 * r * m * Math.PI;
                terfogat = r * r * Math.PI * m;

                label3.Text = "F = " + felszin.ToString();
                label4.Text = "V = " + terfogat.ToString();
            }
        }

        private void GombSzamitas()
        {
            if (rSugarTextBox.Text != "")
            {
                r = Convert.ToDouble(rSugarTextBox.Text);

                felszin = 4 * r * r * Math.PI;
                terfogat = (4 * r * r * r * Math.PI) / 3;

                label3.Text = "F = " + felszin.ToString();
                label4.Text = "V = " + terfogat.ToString();
            }
        }

        private void KorSzamitas()
        {
            if (rSugarTextBox.Text!="")
            {
                r = Convert.ToDouble(rSugarTextBox.Text);

                kerulet = 2 * r * Math.PI;
                terulet = r * r * Math.PI;

                label3.Text = "K = " + kerulet.ToString();
                label4.Text = "T = " + terulet.ToString();
            }
        }

        private void NegyzetSzamitas()
        {
            if (aOldalTextBox.Text!="")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);

                kerulet = a * 4;
                terulet = a * a;

                label3.Text = "K = " + kerulet.ToString();
                label4.Text = "T = " + terulet.ToString();
            }
            
        }
        private void HaromszogSzamitas()
        {
            if (aOldalTextBox.Text != "" && bOldalTextBox.Text != "" && cOldalTextBox.Text != "" && aOldalMagassag.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                b = Convert.ToDouble(bOldalTextBox.Text);
                c = Convert.ToDouble(cOldalTextBox.Text);
                ma = Convert.ToDouble(aOldalMagassagTextBox.Text);
                if (a>b+c||b>a+c||c>a+b||ma>b||ma>c)
                {
                    kerulet = a + b + c;
                    terulet = (a * ma) / 2;
                    
                    label4.Text = "T = " + kerulet.ToString();
                    label3.Text = "K = " + terulet.ToString();
                }
            }
        }
        private void RombuszSzamitas()
        {
            if (aOldalTextBox.Text != "" && eOldalTextBox.Text != "" && fOldalTextBox.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                e = Convert.ToDouble(eOldalTextBox.Text);
                f = Convert.ToDouble(fOldalTextBox.Text);

                kerulet = 4 * a;
                terulet = e * f / 2;

                label4.Text = "T = " + kerulet.ToString();
                label3.Text = "K = " + terulet.ToString();
            }
           
        }

        private void DeltoidSzamitas()
        {
            if (aOldalTextBox.Text != "" && eOldalTextBox.Text != "" && fOldalTextBox.Text != "" && bOldalTextBox.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                b = Convert.ToDouble(bOldalTextBox.Text);
                e = Convert.ToDouble(eOldalTextBox.Text);
                f = Convert.ToDouble(fOldalTextBox.Text);

                kerulet = (a + b) * 2;
                terulet = e * f / 2;

                label4.Text = "T = " + kerulet.ToString();
                label3.Text = "K = " + terulet.ToString();
            }
            
        }

        private void TeglalapSzamitas()
        {
            if (aOldalTextBox.Text != "" && bOldalTextBox.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                b = Convert.ToDouble(bOldalTextBox.Text);

                kerulet = (a + b) * 2;
                terulet = a * b;

                label4.Text = "T = " + kerulet.ToString();
                label3.Text = "K = " + terulet.ToString();
            }
        }

        private void TrapezSzamitas()
        {
            if (aOldalTextBox.Text != "" && bOldalTextBox.Text != "" && cOldalTextBox.Text != "" && dOldalTextBox.Text != "" && aOldalMagassagTextBox.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                b = Convert.ToDouble(bOldalTextBox.Text);
                c = Convert.ToDouble(cOldalTextBox.Text);
                d = Convert.ToDouble(dOldalTextBox.Text);
                ma = Convert.ToDouble(aOldalMagassagTextBox.Text);

                kerulet = a + b + c + d;
                terulet = (a + c) * ma / 2;

                label4.Text = "T = " + kerulet.ToString();
                label3.Text = "K = " + terulet.ToString();
            }
            
        }

        private void ParalelogrammaSzamitas()
        {
            if (aOldalTextBox.Text != "" && bOldalTextBox.Text != "" && aOldalMagassag.Text != "")
            {
                a = Convert.ToDouble(aOldalTextBox.Text);
                b = Convert.ToDouble(bOldalTextBox.Text);
                ma = Convert.ToDouble(aOldalMagassagTextBox.Text);

                kerulet = (a+b)*2;
                terulet = a*ma;

                label3.Text = "K = " + terulet.ToString();
                label4.Text = "T = " + kerulet.ToString();
            }
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
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Eoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Eoldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void fOldalTextBox_Click(object sender, EventArgs e)
        {
            if (Aktkep.Split('_').Length == 1)
            {
                Aktkep = Aktkep.Split('.')[0] + "_Foldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
            else
            {
                Aktkep = Aktkep.Split('_')[0] + "_Foldal.png";
                alakzatPictureBox.Image = Image.FromFile(@Aktkep);
            }
        }

        private void bOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(bOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                bOldalTextBox.Text = bOldalTextBox.Text.Remove(bOldalTextBox.Text.Length - 1);
            }
        }

        private void cOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                cOldalTextBox.Text = cOldalTextBox.Text.Remove(cOldalTextBox.Text.Length - 1);
            }
        }

        private void dOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(dOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                dOldalTextBox.Text = dOldalTextBox.Text.Remove(dOldalTextBox.Text.Length - 1);
            }
        }

        private void aOldalMagassagTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(aOldalMagassagTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                aOldalMagassagTextBox.Text = aOldalMagassagTextBox.Text.Remove(aOldalMagassagTextBox.Text.Length - 1);
            }
        }

        private void rSugarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rSugarTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                rSugarTextBox.Text = rSugarTextBox.Text.Remove(rSugarTextBox.Text.Length - 1);
            }
        }

        private void eOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(eOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                eOldalTextBox.Text = eOldalTextBox.Text.Remove(eOldalTextBox.Text.Length - 1);
            }
        }

        private void fOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                fOldalTextBox.Text = fOldalTextBox.Text.Remove(fOldalTextBox.Text.Length - 1);
            }
        }

        private void mOldalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mOldalTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számokat lehet beírni.");
                mOldalTextBox.Text = mOldalTextBox.Text.Remove(mOldalTextBox.Text.Length - 1);
            }
        }
    }
}
