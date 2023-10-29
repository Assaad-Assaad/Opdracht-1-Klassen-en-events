

using System.Runtime.CompilerServices;

namespace Opdracht_Klassen_En_Events.Models


{
    public delegate void BookOrderedEventHandler();


    public class Order<TItem>

    {
        public event BookOrderedEventHandler BookOrderedEvent;
        private static int orderCount = 0;
        public TItem Item { get; set; }
        public DateTime Date = DateTime.Now;
        public int AmountOrder { get; set; }

        public int OrderID
        {
            get { return orderCount;} 
            set { OrderID = orderCount; } }

        public Order(TItem item, int AmountOrder)
        {
            this.Item = item;
            this.AmountOrder = AmountOrder;
            orderCount++;

        }



        public Tuple<string, int, double> OrderInfo(TItem Item)
        {
            if (Item is Book book)

            {
                double totalPrice = AmountOrder * book.Price;

                return new Tuple<string, int, double>(book.ISBN, AmountOrder, totalPrice);

            }
            else if (Item is Magazine magazine)
            {
                double totalPrice = AmountOrder * magazine.Price;

                return new Tuple<string, int, double>(magazine.ISBN, AmountOrder, totalPrice);
            }
            else
            {
                throw new InvalidOperationException("Invalid item type.");
            }
        }

        public void ConfirmedOrder()
        {
            

                BookOrderedEvent += new BookOrderedEventHandler(ordreIsABook);
                BookOrderedEvent?.Invoke();
        }

        public void ordreIsABook()
        {
            if (Item is Book book)
            {
                Console.WriteLine($"Book '{book.Name}' is ordered with ID {OrderID}.");
            }
                
            
           
        }
    }
}
