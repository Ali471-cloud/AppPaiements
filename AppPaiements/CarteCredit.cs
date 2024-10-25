public class CarteCredit : Paiement
{
    public int NumeroCarte { get; set; }

    // Constructeur de la classe CarteCredit
    public CarteCredit(double montant, string description, int numeroCarte)
        : base(montant, description)
    {
        NumeroCarte = numeroCarte;
    }

    // Affiche les détails du paiement par Carte de Crédit
    public override void AfficherDetails()
    {
        Console.WriteLine($"Carte de Crédit: Montant = {Montant} €, Description = {Description}, Numéro = {NumeroCarte}");
    }
}
