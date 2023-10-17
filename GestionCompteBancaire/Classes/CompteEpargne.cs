using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompteBancaire
{ 
    public class CompteEpargne : CompteBancaire
{
	public double TauxDinteret { get; set; }
	public CompteEpargne(double solde, string devise, string titulaire, double tauxDinteret):base(solde, devise, titulaire)
	{
        TauxDinteret = tauxDinteret;
	}

    public override void Debiter(double montant)
    {
        if(montant <= solde/2)
        {
            solde = solde - montant;
        }
    }

    public void Crediter(double montant)
    {
        base.Crediter(montant);
    }

    public void AjouterInterets()
    {
        double interets = solde * TauxDinteret;
        solde += interets;
    }

    public override string Decrire()
    {
        return base.Decrire() + ". Son taux d'interet est de " + (TauxDinteret * 100) + "%";
    }
    
    }
}