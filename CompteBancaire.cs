using System;

public abstract class CompteBancaire
{
	private double solde;
	private string devise;
	private Client titulaire;

    public double Solde { get; };
	public string Devise { get; };


    public CompteBancaire(double solde, string devise, Client titulaire)
	{
		this.titulaire = titulaire;
		this.Solde = solde;
		this.Devise = devise;
	}

	public string Decrire()
	{
		string description = "Le solde du compte de " + titulaire.Prenom + " " + titulaire.Nom + " est de " + solde + " " + devise;
		return description;
	}

	public Crediter(double montant)
	{
		this.solde += montant;
	}

	public abstract Debiter(double montant);
}
