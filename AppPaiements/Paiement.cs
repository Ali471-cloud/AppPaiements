public abstract class Paiement
{
    public double Montant { get; set; }
    public string Description { get; set; }

    // Constructeur qui prend le montant et la description en paramètres
    public Paiement(double montant, string description)
    {
        Montant = montant;
        Description = description;
    }

    // Méthode abstraite qui devra être implémentée par les classes filles
    public abstract void AfficherDetails();
}
