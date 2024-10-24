public class CarteCredit : Paiement
{
    public int NumeroCarte { get; set; }

    // Constructeur de la classe CarteCredit
    public CarteCredit(double montant, string description, int numeroCarte)
        : base(montant, description)
    {
        NumeroCarte = numeroCarte;
    }

    // Implémentation de la méthode abstraite AfficherDetails
    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement par Carte de Crédit:");
        Console.WriteLine($"Montant : {Montant}, Description : {Description}, Numéro de Carte : {NumeroCarte}");
    }
}
