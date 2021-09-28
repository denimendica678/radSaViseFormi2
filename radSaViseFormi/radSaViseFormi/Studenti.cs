using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radSaViseFormi
{
    public partial class Studenti : Form
    {

        public Studenti()
        {
            InitializeComponent();
        }

        private void ListBoxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta frm = new UnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();

            // unos novog studenta u listBox

            if (rez == System.Windows.Forms.DialogResult.OK)

                listBoxStudenti.Items.Add(frm.Student1.ToString());

            UnosNovogStudenta unos = new UnosNovogStudenta();
            unos.ShowDialog();
            
        }

        private void buttonObrisiStudent_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))

                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }
    }
}
