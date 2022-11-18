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
        static List<Poziciok> Pozik = new List<Poziciok>();
        public Form1()
        {
            InitializeComponent();
            PozicioFeltoltes();
            Torles();
            alakzatPictureBox.Image = Image.FromFile(@"Háromszög.png");
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
        }
        private void bOldalNemLathato()
        {
            bOldal.Visible = false;
            bOldalTextBox.Visible = false;
            bOldalMertekegyseg.Visible = false;
        }
        private void cOldalNemLathato()
        {
            cOldal.Visible = false;
            cOldalTextBox.Visible = false;
            cOldalMertekegyseg.Visible = false;
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
            alakzatPictureBox.Image = Image.FromFile(@"Háromszög.png");
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            aOldalMagassagLathato(3);
        }

        private void trapezGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Trapéz.png");
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            cOldalLathato(2);
            dOldalLathato(3);
            aOldalMagassagLathato(4);
        }

        private void paralelogrammaGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Paralelogramma.png");
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            aOldalMagassagLathato(2);
        }

        private void teglalapGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Téglalap.png");
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
        }

        private void deltoidGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Deltoid.png");
            Torles();
            aOldalLathato(0);
            bOldalLathato(1);
            eOldalLathato(2);
            fOldalLathato(3);

        }

        private void rombuszGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Rombusz.png");
            Torles();
            aOldalLathato(0);
            eOldalLathato(1);
            fOldalLathato(2);
        }

        private void negyzetGomb_Click(object sender, EventArgs e)
        {
            Torles();
            alakzatPictureBox.Image = Image.FromFile(@"Négyzet.png");
            aOldalLathato(0);
        }

        private void korGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Kör.png");
            Torles();
            rSugarLathato(0);
        }

        private void gombGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Gömb.png");
            Torles();
            rSugarLathato(0);
        }

        private void hengerGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Henger.png");
            Torles();
            mOldalLathato(0);
        }

        private void gulaGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Gúla.png");
            Torles();
            aOldalLathato(0);
            mOldalLathato(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //fOldal.Location = new Point(8, 24);
        }
    }
}
