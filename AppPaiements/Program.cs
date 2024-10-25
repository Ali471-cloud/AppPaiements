class Program
{
    static void Main(string[] args)
    {
        // Création d'exemples de paiements par Carte de Crédit
        CarteCredit carte1 = new CarteCredit(100.50, "Achat en ligne", 12345678);
        CarteCredit carte2 = new CarteCredit(50.25, "Courses alimentaires", 87654321);
        CarteCredit carte3 = new CarteCredit(250.00, "Nouveaux vêtements", 13579246);

        // Création d'exemples de paiements via PayPal
        PayPal paypal1 = new PayPal(30.75, "Abonnement streaming", "email1@exemple.com");
        PayPal paypal2 = new PayPal(120.99, "Commande en ligne", "email2@exemple.com");

        // Affichage des détails des paiements par Carte de Crédit
        Console.WriteLine("Détails des paiements par Carte de Crédit:");
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();

        // Affichage des détails des paiements via PayPal
        Console.WriteLine("\nDétails des paiements via PayPal:");
        paypal1.AfficherDetails();
        paypal2.AfficherDetails();
    }
}
