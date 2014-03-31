using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarityMeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Same articles on minister
            string url1 = "http://www.dailymail.co.uk/news/article-2592103/Minister-faces-censure-expenses-abuse.html";
            string url2 = "http://www.telegraph.co.uk/news/newstopics/mps-expenses/10729984/Maria-Miller-to-have-to-repay-thousands-of-pounds-and-apologise-over-expenses-claims.html";
            
            // Same articles on cricket
            string url3 = "http://www.dailymail.co.uk/sport/cricket/article-2591835/Pietersen-adds-Caribbean-Premier-League-packed-diary-gun-hire-enters-tournament-draft.html";
            string url4 = "http://www.telegraph.co.uk/sport/cricket/kevinpietersen/10730271/Kevin-Pietersen-enters-Caribbean-Premier-League-draft.html";

            string testUrl1 = url1;
            string testUrl2 = url2;

            int treshold = 3;


            try
            {
                SimilarityCalculator sc = new SimilarityCalculator();

                // Comparison of articles about minister (same)
                Console.WriteLine("Comparison of articles about minister (similar articles from dailymail.co.uk and telegraph.co.uk)..");
                sc.Compare(url1, url2, vocabularyTreshold: treshold);

                Console.WriteLine("Comparison of articles about cricket (similar articles from dailymail.co.uk and telegraph.co.uk)..");
                sc.Compare(url3, url4, vocabularyTreshold: treshold);

                Console.WriteLine("Comparison of article about minister and article about cricket (source - dailymail.co.uk)..");
                sc.Compare(url1, url3, vocabularyTreshold: treshold);

                Console.WriteLine("Comparison of article about minister and article about cricket (source - telegraph.co.uk)..");
                sc.Compare(url2, url4, vocabularyTreshold: treshold);

                Console.WriteLine("Comparison of article about minister and article about cricket (source - telegraph.co.uk and dailymail.co.uk)..");
                sc.Compare(url1, url4, vocabularyTreshold: treshold);

                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
