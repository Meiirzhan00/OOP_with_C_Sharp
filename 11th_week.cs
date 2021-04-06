using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP2
{
    interface IComparable
    {
        void Shygaru();
    }

    abstract class Edition
    {
        public abstract void Shygaru();

        public abstract void Sorting();
    }

    class Book : Edition
    {
        public static List<Book> books;
        public string authorName;
        public string authorSurname;
        public int yearRel;
        public string printName;

        static Book()
        {
            books = new List<Book>()
        {
            new Book {authorName="Magzhan", authorSurname = "Zhumabayev", yearRel = 2007, printName = "Samga"},
            new Book {authorName="Abdesh", authorSurname = "Zhumadilov", yearRel = 1997, printName = "Sunkar"},
            new Book {authorName="Fariza", authorSurname = "Ongarsynova", yearRel = 2001, printName = "Atamura"},
            new Book {authorName="Abai", authorSurname = "Kunanbaev", yearRel = 1983, printName = "Kokzhyek"}
        };
        }

        public List<Book> getBookList()
        {
            return books;
        }
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        public override void Shygaru()
        {
            foreach (Book u in books)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.yearRel}   {u.printName}");
        }

        public override void Sorting()
        {
            var result = from b in books
                         orderby b.authorName, b.authorSurname,b.yearRel,b.printName
                         select b;
            foreach (Book u in result)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.yearRel}   {u.printName}");
        }
    }

    class Article : Edition
    {
        public static List<Article> articles;
        public string authorName;
        public string authorSurname;
        public string magName;
        public int magNumber;
        public int yearRel;

        static Article()
        {

            articles = new List<Article>()
        {
            new Article {authorName="Tolegen", authorSurname = "Kalmurza", magName = "OYLA", magNumber = 102,yearRel = 2017},
            new Article {authorName="Mukhtar", authorSurname = "Yessenov", magName = "Yessenov Science Journal", magNumber = 175,yearRel = 2019},
            new Article {authorName="Aybat", authorSurname = "Alenov", magName = "Eurasian mathematical journal", magNumber = 249,yearRel = 2014},
            new Article {authorName="Ulan", authorSurname = "Suleymenov", magName = "Central Asian Economic Review", magNumber = 790,yearRel = 2011}
        };
        }

        public List<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }
        public override void Shygaru()
        {
            foreach (Article u in articles)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.magName}  {u.magNumber}  {u.yearRel}");
        }

        public override void Sorting()
        {
            var result = from b in articles
                         orderby b.authorName, b.authorSurname, b.magName, b.magNumber, b.yearRel
                         select b;
            foreach (Article u in result)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.magName}  {u.magNumber}  {u.yearRel}");
        }
    }

    class OnlineResource : Edition
    {
        public static List<OnlineResource> online { get; set; }
        public string authorName;
        public string authorSurname;
        public string link;
        public string annotation;

        static OnlineResource()
        {
            online = new List<OnlineResource>()
        {
            new OnlineResource {authorName="David", authorSurname = "Allen", link = "https://www.mentalfloss.com/", annotation = "Interesting trivia and facts."},
            new OnlineResource {authorName="Jordan", authorSurname = "Koalitic", link = "http://www.timeforkids.com/", annotation = "Expertly-written news"},
            new OnlineResource {authorName="Cris", authorSurname = "Nate", link = "https://www.shortlist.com/", annotation = "Classy articles for men."},
            new OnlineResource {authorName="Frank", authorSurname = "Jason", link = "https://www.digitalcameraworld.com/", annotation = "Taking pictures."}
        };
        }

        public List<OnlineResource> Online
        {
            get { return online; }
            set { online = value; }
        }
        public override void Shygaru()
        {
            foreach (OnlineResource u in online)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.link}   {u.annotation}");
        }

        public override void Sorting()
        {
            var result = from b in online
                         orderby b.authorName, b.authorSurname, b.link, b.annotation
                         select b;
            foreach (OnlineResource u in result)
                Console.WriteLine($"{u.authorName}  {u.authorSurname}  {u.link}   {u.annotation}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Book booK = new Book();
            Article arTicle = new Article();
            OnlineResource onLine = new OnlineResource();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Basylymdar turaly akparat alu ushin {1}-di bas nemese Avtor boynsha basylymdy izdeu ushun {2}-ni bas:");
            Console.ResetColor();

            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Kay basylymdy tandaysyz: \n1) Book\n2) Article\n3) OnlineResource\n");
                    Console.ResetColor();
                    int selectN = Convert.ToInt32(Console.ReadLine());
                    if (selectN == 1)
                    {
                        Line();
                        booK.Shygaru();
                        Line();
                        Console.Write("Sorttalganyn korginiz kelse y/n : ");
                        Line();
                        string selectM = Console.ReadLine();
                        if (selectM == "y") { 
                            
                            Console.ForegroundColor = ConsoleColor.Yellow; 
                            Console.WriteLine("Sorttalgan basylym :");
                            Console.ResetColor();
                            Line();
                            booK.Sorting();
                            Line();
                        
                        }
                        else { Console.WriteLine("Bi,Bi :)"); };
                    }

                    else if (selectN == 2)
                    {
                        Line();
                        arTicle.Shygaru();
                        Line();
                        Console.Write("Sorttalganyn korginiz kelse y/n : ");
                        string selectM = Console.ReadLine();
                        if (selectM == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sorttalgan basylym :");
                            Console.ResetColor();
                            Line();
                            arTicle.Sorting();
                            Line();
                        }
                        else { Console.WriteLine("Bi,Bi :)"); };
                    }

                    else if (selectN == 3)
                    {
                        Line();
                        onLine.Shygaru();
                        Line();
                        Console.Write("Sorttalganyn korginiz kelse y/n : ");
                        string selectM = Console.ReadLine();
                        if (selectM == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sorttalgan basylym :");
                            Console.ResetColor();
                            Line();
                            onLine.Sorting();
                            Line();
                        }
                        else { Console.WriteLine("Bi,Bi :)"); };
                    }
                    else { Console.WriteLine("Bi,Bi :)"); };
                    break;

                //case 2:
                //    Console.ForegroundColor = ConsoleColor.Yellow;
                //    Console.WriteLine("Kay basylymdy tandaysyz: \n1) Book\n2) Article\n3) OnlineResource\n");
                //    Console.ResetColor();
                //    int selectC = Convert.ToInt32(Console.ReadLine());
                //    if (selectC == 1)
                //    {
                //        Console.Write("Basylym avtorynyn tegin engiz : ");
                //        string selectS = Console.ReadLine();
                //        for (int i = 0; i < 4; i++)
                //        {
                //            if (selectS == booK.Books[i].authorSurname)
                //            {
                //                booK.Books[i].Shygaru();
                //            }

                //            else { Console.WriteLine($"{selectS} esimdi avtor tabylmady !"); }
                //        }
                //    }

                //    else if (selectC == 2)
                //    {
                //        Console.Write("Basylym avtorynyn tegin engiz : ");
                //        string selectS = Console.ReadLine();
                //        for (int i = 0; i < 4; i++)
                //        {
                //            if (selectS == arTicle.Articles[i].authorSurname)
                //            {
                //                arTicle.Articles[i].Shygaru();
                //            }

                //            else { Console.WriteLine($"{selectS} esimdi avtor tabylmady !"); }
                //        }
                //    }

                //    else if (selectC == 3)
                //    {
                //        Console.Write("Basylym avtorynyn tegin engiz : ");
                //        string selectS = Console.ReadLine();
                //        for (int i = 0; i < 4; i++)
                //        {
                //            if (selectS == onLine.Online[i].authorSurname)
                //            {
                //                onLine.Online[i].Shygaru();
                //            }

                //            else { Console.WriteLine($"{selectS} esimdi avtor tabylmady !"); }
                //        }
                //    }

                //    else { Console.WriteLine("Bi,Bi :)"); }

                //    break;
            }
        } 
        static void Line()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

}
