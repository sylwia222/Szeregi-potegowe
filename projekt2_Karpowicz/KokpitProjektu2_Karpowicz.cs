using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt2_Karpowicz
{
    public partial class KokpitProjektu2_Karpowicz : Form
    {
        public KokpitProjektu2_Karpowicz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form Formuarz in Application.OpenForms)
                if (Formuarz.Name == "SzeregIndywidualny")
                {
                    this.Hide();
                    Formuarz.Show();
                    return;
                }
            SzeregIndywidualny AnalizatorSzeregu = new SzeregIndywidualny();
            AnalizatorSzeregu.Show();
            this.Hide();

        }

        private void btnSzeregLaboratoryjny_Click(object sender, EventArgs e)
        {
            foreach (Form Formuarz in Application.OpenForms)
                if (Formuarz.Name == "Szereglaboratoryjny")
                {
                    this.Hide();
                    Formuarz.Show();
                    return;
                }
            SzeregLaboratoryjny AnalizatorSzeregu = new SzeregLaboratoryjny();
            AnalizatorSzeregu.Show();
            this.Hide();
        }

        private void KokpitProjektu2_Karpowicz_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoMessage = MessageBox.Show("Czy napewno chcesz zamknąć formularz główny i zakończyć " +
                "działanie programu", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (OknoMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
    }
}
