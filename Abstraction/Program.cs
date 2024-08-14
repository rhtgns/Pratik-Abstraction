using System;
using System.Diagnostics.Contracts;

namespace CoWorkers
{
    // burda soyut yani abstract sınıfı oluituralım

    public abstract class Workers
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Department { get; set; }



        // ardından simdi abstract metofumu cagıralım

        public abstract void mission();



    }

    // burda yazılım geliştirici sınfını yapalım

    public class SoftwareDeveloper : Workers
    {
        public override void mission()
        {
            Console.WriteLine($"{Name} {SurName} sirketin yazılım geliştiricisi , Yazılım geliştiricisi olarak çalışıyorum ");
        }


    }

    public class  Seller : Workers
    {
        public override void mission()
        {
            Console.WriteLine($"{Name} {SurName} şirketin satıs temsilcisi, satış temsilcisi olarak çalışıyorum");
        }
    }
    public  class ProjectManager  : Workers
    {
        public override void mission()
        {
            Console.WriteLine($" {Name} {SurName} sirketin proje yöneticisi , projede yonetici olarak çalışıyorum");
        }
    }
}
