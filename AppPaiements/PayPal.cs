public class PayPal : Paiement
{
    public string Email { get; set; }

    // Constructeur de la classe PayPal
    public PayPal(double montant, string description, string email)
        : base(montant, description)
    {
        Email = email;
    }

    // Implémentation de la méthode abstraite AfficherDetails
    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement via PayPal:");
        Console.WriteLine($"Montant : {Montant}, Description : {Description}, Email : {Email}");
    }
}
