using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleType
{
        public enum TypeArticleEnum
        {
            Alimentaire,
            Droguerie,
            Habillement,
            Loisir
        }

        public struct Article
        {
            private string designation { get; set; }

            private double prix { get; set; }

            private int quantité { get; set; }

            private TypeArticleEnum _typeArticleEnum;


            public Article(string designation, double prix, int quantite, TypeArticleEnum typeArticleEnum)
            {
                this.designation = designation;
                this.prix = prix;
                this.quantité = quantite;
                this._typeArticleEnum = typeArticleEnum;
            }

            public void afficher()
            {
                Console.WriteLine("[Affichage Article]");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Nom de l'article : " + designation);
                Console.WriteLine("Prix de l'article : " + prix + " euros");
                Console.WriteLine("Quantité de l'Article : " + quantité);

                if (_typeArticleEnum == TypeArticleEnum.Alimentaire)
                     Console.WriteLine("Type de l'article : Alimentaire");
                

                else if (_typeArticleEnum == TypeArticleEnum.Droguerie)
                     Console.WriteLine("Type de l'article : Droguerie");
               

                else if (_typeArticleEnum == TypeArticleEnum.Habillement)
                     Console.WriteLine("Type de l'article : Habillement");
                

                else if (_typeArticleEnum == TypeArticleEnum.Loisir)
                        Console.WriteLine("Type de l'article : Loisir");
                
                Console.WriteLine(Environment.NewLine);
            }

            public void ajouter()
            {
                this.quantité += 1;
            }


            public void Supprimer()
            {
                if (this.quantité >= 1)
                {
                    this.quantité -= 1;
                }
                else
                {
                    Console.WriteLine("Plus aucune quantité n'est disponible.");
                }
            }
        }
    }

