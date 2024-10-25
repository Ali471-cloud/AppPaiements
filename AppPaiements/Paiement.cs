public abstract class Paiement
{
    public double Montant { get; set; }
    public string Description { get; set; }

    // Constructeur de base pour Paiement
    public Paiement(double montant, string description)
    {
        Montant = montant;
        Description = description;
    }

    // Méthode abstraite pour afficher les détails
    public abstract void AfficherDetails();
}
