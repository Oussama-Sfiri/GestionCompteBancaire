using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompteBancaire
{ 
    public abstract class CompteBancaire
{
	protected double solde;
	protected string devise;
	protected string titulaire;

    public double Solde { get; set; }
	public string Devise { get; set; }
    public string Titulaire { get; set; }

        public CompteBancaire(double solde, string devise, string titulaire)
	{
		this.titulaire = titulaire;
		this.solde = solde;
		this.devise = devise;
	}

	public virtual string Decrire()
	{
		string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
		return description;
	}

	public void Crediter(double montant)
	{
		this.solde += montant;
	}

	public abstract void Debiter(double montant);
}
}