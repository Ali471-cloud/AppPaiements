public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Email { get; set; }

    // Constructeur de la classe Utilisateur
    public Utilisateur(string nom, string prenom, string email)
    {
        Nom = nom;
        Prenom = prenom;
        Email = email;
    }

    // Méthode pour afficher les détails de l'utilisateur
    public void AfficherDetails()
    {
        Console.WriteLine($"Nom : {Nom}, Prénom : {Prenom}, Email : {Email}");
    }
}
