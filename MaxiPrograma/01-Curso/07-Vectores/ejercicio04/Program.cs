/* 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos: */
/* - Número de Artículo (1 a 15) */
/* - Cantidad Vendida */ 

/* Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0. */
/* Se pide determinar e informar: */
/* a) El número de artículo que más se vendió en total. */
/* b) Los números de artículos que no registraron ventas. */
/* c) Cuantas unidades se vendieron del número de artículo 10. */
using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] articles = new int[15];
            int article, quantitySold, bestSeller, indexSeller;

            do{
                Console.Write("Article: ");
                article = int.Parse(Console.ReadLine());
                if(article != 0){
                    Console.Write("Quantity: ");
                    quantitySold = int.Parse(Console.ReadLine());

                    articles[article-1] += quantitySold;
                }
            }while(article !=0);

            bestSeller = 0;
            indexSeller = 0;
            for(int i=0; i < 15; i++){
                if(articles[i] > bestSeller){
                    bestSeller = articles[i];
                    indexSeller = i+1;
                }
                if(articles[i] == 0)
                    Console.Write("Article "+(i+1)+" sale 0.\n");
            }
            Console.Write("Top selling article: " + indexSeller+"\n");
            Console.Write("Article 10: " + articles[9]);
        }
    }
}
