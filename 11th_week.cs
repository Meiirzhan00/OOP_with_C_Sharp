using OOP2;
using System;
using System.Collections.Generic;

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
            this.authorName = authorName;
            this.authorSurname = authorSurname;
            this.link = link;
            this.annotation = annotation;
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
            List<Book> books = new List<Book>();
            List<Article> articles = new List<Article>();
            List<OnlineResource> onlineResources=new List<OnlineResource>();

            
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
