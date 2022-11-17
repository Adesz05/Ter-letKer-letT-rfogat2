using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeruletKeruletTerfogat
{
    class Poziciok
    {
        public Koordinatak Label, TextBox, ComboBox;

        public Poziciok(Koordinatak label, Koordinatak textbox, Koordinatak combobox)
        {
            Label = label;
            TextBox = textbox;
            ComboBox = combobox;
        }
    }
}
