using System;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article("Fifa 20 ", 5, 10, TypeArticleEnum.Loisir);
           
            Article article2 = new Article("television", 500, 2, TypeArticleEnum.Loisir);

            Article article3 = new Article("maillot EAG ", 50, 1, TypeArticleEnum.Habillement);

            var tableauArticle = new Article[] { article1, article2, article3 };

            for (int i = 0; i < tableauArticle.Length; i++)
            {
                tableauArticle[i].afficher();
            }

            Console.WriteLine("[Modification quantitée television]");

            tableauArticle[2].Supprimer();
            tableauArticle[2].afficher();

        }
    }
}
