using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCompteBancaire
{
    public partial class FormCompteCourant : Form
    {
        private String numeroCB;
        private double decouverteMax;
        private CompteCourant cptCourant;

        public FormCompteCourant(CompteCourant cptCourant)
        {
            InitializeComponent();
            this.cptCourant = cptCourant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caption = "Saisie du montant";
            string prompt = "Veuillez saisir le montant :";
            string montantSaisi = Microsoft.VisualBasic.Interaction.InputBox(prompt, caption, "");

            if (!string.IsNullOrEmpty(montantSaisi))
            {
                double montantSaisie = Double.Parse(montantSaisi);
                cptCourant.Debiter(montantSaisie);
                MessageBox.Show("Montant saisi " + montantSaisie + " et le solde restant est " + cptCourant.Solde);
            }
            else
            {
                // L'utilisateur a annulé l'opération
                MessageBox.Show("Opération annulée");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numeroCB) && decouverteMax != 0)
            {
                cptCourant.NumeroCB = numeroCB;
                cptCourant.DecouverteMax = decouverteMax;
                MessageBox.Show(cptCourant.Decrire());
            }
            else
            {
                MessageBox.Show("Please fill all the data");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numeroCB = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            decouverteMax = Double.Parse(textBox2.Text);
        }

        private void FormCompteCourant_Load(object sender, EventArgs e)
        {

        }
    }
}
