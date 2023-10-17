using System;

public class Client
{
	private int numero;
	private string nom;
	private string prenom;
	private List<CompteBancaire> comptes;

	public int Numero { get; }
	public int Nom { get; }
	public string Prenom { get; }
	public List<CompteBancaire> Comptes { get; set; }

	public Client(int numero, string nom, string prenom)
	{
		this.Numero = numero;
		this.Nom = nom;
		this.Prenom = prenom;
		Comptes = new List<CompteBancaire>;
	}
}
