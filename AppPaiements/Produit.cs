public class Produit
{
    public string Nom { get; set; }
    public double Prix { get; set; }

    public Produit(string nom, double prix)
    {
        Nom = nom;
        Prix = prix;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Produit : {Nom}, Prix : {Prix}");
    }
}
