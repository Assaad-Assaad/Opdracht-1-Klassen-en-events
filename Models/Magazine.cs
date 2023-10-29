

namespace Opdracht_Klassen_En_Events.Models
{

    public enum PublicationPeriod { Daily, Weekly, Monthly }

    public class Magazine : Book

    {
        
        public PublicationPeriod PublicationPeriod { get; set; }

        public Magazine() { }


        public Magazine(string ISBN, string Name, string Publisher, double Price, PublicationPeriod publicationPeriod) :
            base(ISBN, Name, Publisher, Price)
        {
            this.PublicationPeriod = publicationPeriod;
        }

        public override string ToString()
        {
            return $"{base.ToString()} PublicationPeriod: {PublicationPeriod}";
        }
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
   
}
