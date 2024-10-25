public class PayPal : Paiement
{
    public string Email { get; set; }

    // Constructeur de la classe PayPal
    public PayPal(double montant, string description, string email)
        : base(montant, description)
    {
        Email = email;
    }

    // Affiche les détails du paiement PayPal
    public override void AfficherDetails()
    {
        Console.WriteLine($"PayPal: Montant = {Montant} €, Description = {Description}, Email = {Email}");
    }
}
