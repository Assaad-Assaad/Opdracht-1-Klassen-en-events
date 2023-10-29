

using System;

namespace Opdracht_Klassen_En_Events.Models
{
    public   class Book
    {
        public string ISBN { get; set; }
        public string Name { get; set;  }
        public string Publisher { get; set; }
        public double Price { get; set; }
        
        





        public Book() { }


        public Book(string ISBN, string Name, string Publisher, double Price)
        {
            this.ISBN = ISBN;
            this.Name = Name;
            this.Publisher = Publisher;
            if (Price < 5.0 || Price > 50.0)
            {
                throw new ArgumentException("The price must be between 5 & 50", nameof(Book));
            }

            this.Price = Price;
            

                

            

        }

        public virtual string ToString()
        {
            return $"{GetType().Name} ISBN: {ISBN} Name: {Name} Publisher: {Publisher} Price: {Price}";
        }

        static void Read(Book book)
        {
                Console.WriteLine("Enter the ISBN: ");
                var isbn = Console.ReadLine();
                Console.WriteLine("Enter the name of the book: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the publisher name: ");
                var publisher = Console.ReadLine();
                Console.WriteLine("Enter the price: ");
                var price = double.Parse(Console.ReadLine());

        }


    }
}
