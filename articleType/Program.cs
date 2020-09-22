using System;

namespace ArticleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article("pomme", 5, 10, TypeArticleEnum.Alimentaire);
            article1.afficher();

            Article article2 = new Article("television", 500, 2, TypeArticleEnum.Alimentaire);
            article2.afficher();

            article1.ajouter();
            article2.Supprimer();
            article1.afficher();
            article2.afficher();

            Console.WriteLine("[Creation d'un article]");

            Console.WriteLine("Nom de l'article : ");
            string nomNewArticle = Console.ReadLine();

            Console.WriteLine("Prix de l'article");
            double prixNewArticle;

            while (!double.TryParse(Console.ReadLine(), out prixNewArticle))
            {
                Console.WriteLine("Erreur : Format du prix incorrect");
            };

            Console.WriteLine("Quantité de l'article");
            int quantiteNewArticle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type : ");

            Console.WriteLine("1. Alimentaire ");
            Console.WriteLine("2. Droguerie");
            Console.WriteLine("3. Habillement");
            Console.WriteLine("4. Loisir : ");

            TypeArticleEnum typeNewArticle = (TypeArticleEnum)(Convert.ToInt32(Console.ReadLine()) - 1);

            Console.WriteLine(Environment.NewLine);
            Article newArticle = new Article(nomNewArticle, prixNewArticle, quantiteNewArticle, typeNewArticle);

            newArticle.afficher();

        }
    }
}
