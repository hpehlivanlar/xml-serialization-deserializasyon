using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;//XMl ile çalışma sınıf/kütüphanesi

namespace xml_serialization_deserializasyon
{
    class Program
    {
        /*XMl nedir ne iş yapar!!!!!!
         * 
         * Yapısal nod'lar kullanılan bir metinsel dosya biçimleridir.
         * 
         * Oluşturulan mekanizmayı xml serileştirmesiyle düzenli bir veri akışı sağlanır ve kaydı tutulur
         * 
         * Oluşturulan mekanizma sayseinde xml deserializasyonada bu vefinin düzenli sıralı ve hızlı bir şekilde geri okuma ve erişimi sağlanır
         * 
         * node - nokta  : o sınıfa ait  fieldları temsil eder
         * root -- o sınıfın kendisini temsil eder
         * 
         * 
         * 
         * 
         * */


        static void Main(string[] args)
        {

            //Xml yapsisi
            XDocument document = new XDocument();

            //alan ekeleme işlemi
            document.Add(new XElement("Pc",

                new XElement("HP",

                new XElement("Model", 500),
                new XElement("Fiyat", 500)),

                

                new XElement("Acer",

                new XElement("Model", 1500),
                new XElement("Fiyat", 10500))


            ) );

            document.Save("pc.xml");


        }
    }
}
