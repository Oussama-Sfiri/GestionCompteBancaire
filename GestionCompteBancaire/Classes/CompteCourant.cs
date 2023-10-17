using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompteBancaire
{
    public class CompteCourant:CompteBancaire
    {
        private String numeroCB;
        private double decouverteMax;

        public String NumeroCB { get; set; }
        public double DecouverteMax { get ; set; }

        public CompteCourant(double solde, string devise, string titulaire, string numeroCB, double decouverteMax) : base(solde, devise, titulaire)
        {
            NumeroCB = numeroCB;
            DecouverteMax = decouverteMax;
        }

        public override void Debiter(double montant)
        {
            if(solde - montant  >= decouverteMax)
            {
                solde -= montant;
            }
        }

        public override string Decrire()
        {
            return base.Decrire() + ". Son numero CB est " + numeroCB + " et son decouverte maximale est de "+decouverteMax+" "+devise+".";
        }

        public void Crediter(double montant)
        {
            base.Crediter(montant);
        }
    }
}
