class Program
{
    static void Main(string[] args)
    {
        // Créer trois instances de CarteCredit avec des informations de paiement récentes
        CarteCredit carte1 = new CarteCredit(100.50, "Achat en ligne", 12345678);
        CarteCredit carte2 = new CarteCredit(50.25, "Achat d'épicerie", 87654321);
        CarteCredit carte3 = new CarteCredit(250.00, "Achat de vêtements", 13579246);

        // Afficher les détails des paiements
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();
    }
}
