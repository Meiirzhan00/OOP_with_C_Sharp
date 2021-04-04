/* 7-нұсқа
           Түбір абстрактылы базалық класын құрып, оның құрамында түбірлерді есептеп, нәтижені экранға шығару абстрактылы әдістерін анықтаңыз. 
           Бұл кластан туынды Сызықтық және Квадрат кластарын құрып, олардың құрамында сәйкесінше, сызықтық және квадрат теңдеулер түбірлерін табу және 
           экранға шығару әдістерін қайта анықтаңыз. Аталған кластар құрамында қажетті өрістерді және оларды базалық немесе туынды класта анықтаудың 
           дұрыстығы туралы шешімді өзіңіз қабылдаңыз.
 */

using OOP2;
using System;

namespace OOP2
{
    interface IComparable
    {
        void Shygaru();
    }

    abstract class Edition
    {
        public abstract void Shygaru();

        public abstract void CompareTo();
    }
    
    class Book : Edition
    {
        public string authorName;
        public string authorSurname;
        public int yearRel;
        public string printName;
        public Book(string authorName , string authorSurname, int yearRel, string printName)
        {
            this.authorName = authorName;
            this.authorSurname = authorSurname;
            this.yearRel = yearRel;
            this.printName = printName;
        }
        public override void Shygaru()
        {
            throw new NotImplementedException();
        }

        public override void CompareTo()
        {
            throw new NotImplementedException();
        }
    }

    class Article : Edition
    {
        public string authorName;
        public string authorSurname;
        public string magName;
        public int magNumber;
        public int yearRel;
        public Article(string authorName, string authorSurname, string magName, int magNumber , int yearRel)
        {
            this.authorName = authorName;
            this.authorSurname = authorSurname;
            this.magName = magName;
            this.magNumber = magNumber;
            this.yearRel = yearRel;
        }
        public override void Shygaru()
        {
            throw new NotImplementedException();
        }

        public override void CompareTo()
        {
            throw new NotImplementedException();
        }
    }

    class OnlineResource : Edition
    {
        public string authorName;
        public string authorSurname;
        public string link;
        public string annotation;

        public OnlineResource(string authorName, string authorSurname,string link, string annotation)
        {

        }
        public override void Shygaru()
        {
            throw new NotImplementedException();
        }

        public override void CompareTo()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
           
        }
        static void Line()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

}
