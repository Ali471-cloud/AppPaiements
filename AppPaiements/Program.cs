class Program
{
    static void Main(string[] args)
    {
        // Créer trois instances de CarteCredit avec des informations de paiement récentes
        CarteCredit carte1 = new CarteCredit(100.50, "Achat en ligne", 12345678);
        CarteCredit carte2 = new CarteCredit(50.25, "Achat d'épicerie", 87654321);
        CarteCredit carte3 = new CarteCredit(250.00, "Achat de vêtements", 13579246);

        // Créer deux instances de PayPal avec des informations de paiement récentes
        PayPal paypal1 = new PayPal(30.75, "Abonnement Netflix", "monemail1@exemple.com");
        PayPal paypal2 = new PayPal(120.99, "Achat sur eBay", "monemail2@exemple.com");

        // Afficher les détails des paiements CarteCredit
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();

        // Afficher les détails des paiements PayPal
        paypal1.AfficherDetails();
        paypal2.AfficherDetails();
    }
}

