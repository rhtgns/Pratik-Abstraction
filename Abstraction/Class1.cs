using CoWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Workers
    {

        class Program
        {
            static void Main(string[] args)
            {
                // Yazılım Geliştirici nesnesi oluşturma ve metodu çağırma
                SoftwareDeveloper yazilimci = new SoftwareDeveloper
                {
                    Name = "Ahmet",
                    SurName= "Yılmaz",
                    Department ="yazılımcı"
                    
                    
                };
                yazilimci.mission();

                // Proje Yöneticisi nesnesi oluşturma ve metodu çağırma
                ProjectManager yonetici = new ProjectManager
                {
                    Name = "Hasan",
                    SurName = "Çıldırmış",
                    Department = "Proje Yönetimi"
                };
                yonetici.mission();

                // Satış Temsilcisi nesnesi oluşturma ve metodu çağırma
                Seller seller = new Seller
                {
                    Name = "Zeynep",
                    SurName = "Kaya",
                    Department = "Satış"
                };
                seller.mission();
            }
        }
    }
}
