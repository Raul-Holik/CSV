using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Osoba> osobaList = new List<Osoba>();

            try
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, txtMail.Text, Convert.ToInt16(txtGod.Text));
                txtIme.Clear();
                txtPrezime.Clear();
                txtGod.Clear();
                txtMail.Clear();

                DialogResult upit = MessageBox.Show("Želite li unijeti još podataka" + MessageBoxButtons.YesNo + MessageBoxIcon.Question);

                switch(upit)
                {
                    case DialogResult.Yes:
                        {
                            osobaList.Add(osoba);
                            break;
                        }
                    case DialogResult.No:
                        {
                            osobaList.Add(osoba);
                            string file = @"C:\Users\ucenik\Documents\Raul Dominik Holik";
                            string separator = ",";
                            StringBuilder output = new StringBuilder();
                            String[] headings = { "Ime", "Prezime", "Email", "Godina rođenja" };
                            output.AppendLine(string.Join(separator, headings));

                            break;
                        }
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message,"Pogresan unos", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
