using System.Drawing.Imaging;

namespace GestionCompteBancaire
{
    public partial class FormHome : Form
    {
        private string titulaire;
        private double solde;
        private string devise;
        public FormHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (titulaire != null && solde != 0 && devise != null)
            {
                CompteCourant cptCourant = new CompteCourant(solde, devise, titulaire, "", 0);
                MessageBox.Show(cptCourant.Decrire());
            }
            else
            {
                MessageBox.Show("Please Fill all data");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(titulaire) && solde != 0 && !string.IsNullOrEmpty(devise)
            {
                CompteCourant cptCourant = new CompteCourant(solde, devise, titulaire, "", 0);
                FormCompteCourant form2 = new FormCompteCourant(cptCourant);
                form2.Show(); // Utilisez ShowDialog pour attendre que l'utilisateur termine
            }
            else
            {
                MessageBox.Show("Please Fill all data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (titulaire != null && solde != 0 && devise != null)
            {
                CompteEpargne cptEpargne = new CompteEpargne(solde, devise, titulaire, 0);
                FormCompteEpargne form3 = new FormCompteEpargne(cptEpargne);
                form3.Show(); // Utilisez ShowDialog pour attendre que l'utilisateur termine
            }
            else
            {
                MessageBox.Show("Please Fill all data");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titulaire = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            solde = Double.Parse(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            devise = textBox2.Text;
        }
    }
}