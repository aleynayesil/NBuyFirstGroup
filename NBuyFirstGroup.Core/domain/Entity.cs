using NbuyFirstGroup.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    //bu sınıftan instance alınamaz ama diğer sınıflar bu sınıftan instance alıp entity özelliği kazanacaklar
    //her entitynin ıd si olduğu için bu sınıf içerisine koyduk
    public abstract class Entity
    {
        public string Id { get; set; }
      
       // public abstract void Raise(IDomainEvent @event);//c# yasaklı olanlar @ işareti ile kullanabiliriz.entitylerin hepsi even oluyor eventin ilk tetiklendiği yer
    } 
    public class ProductCreated : IDomainEvent
    {
        public string Name { get; set; }
    }
    public class Product : Entity
     {
            public void IncreasePrice(double newPrice)
            {
                DomainEvent.Raise(new ProductCreated());
            }
     }
}
