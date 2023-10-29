

using Opdracht_Klassen_En_Events.Models;
using static Opdracht_Klassen_En_Events.Models.Magazine;

var magazine1 = new Magazine("15976368900", "Daily News", "Someone", 9.99, PublicationPeriod.Daily);
var magazine2 = new Magazine("19161616946", "Weakly News", "Somebody ", 19.99, PublicationPeriod.Weekly);

var book1 = new Book()
{
    ISBN = "0848801202",
    Name = "Animal Farm",
    Publisher = "George Orwell",
    Price = 29.95,
};

var book2 = new Book()
{
    ISBN = "02846895954",
    Name = "The Merchant of Venice",
    Publisher = "Shakespeare",
    Price = 39.95,
};

Order<Book> order1 = new Order<Book>(book1, 2);
order1.ConfirmedOrder();
Order<Book> order2 = new Order<Book>(book2, 3);

order2.ConfirmedOrder();










