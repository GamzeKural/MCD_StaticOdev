using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_StaticOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Müşteri adında bir nesne oluşturalım ve oluşturmuş olduğumuz nesnemizin
             * içerisinde static olarak bir ArrayList oluşturalım.
             * 
             * Oluşturmuş olduğumuz ArrayList koleksiyonumuzu sanal bir database mantığında
             * kullanacağız.
             * 
             * Müşteri sınıfımızın içerisine ID,Isim,Soyisim,EmailAdres,KullaniciAdi,
             * Sifre isimleri ile fieldlar oluşturalım.
             * 
             * Oluşturmuş olduğumuz bu field listesinden bazılarının kapsülleme filtreleri
             * aşağıdaki gibi olmalıdır.
             * 
             * Kullanıcı adı değeri sanal olarak oluşturmuş olduğumuz database imiz içerisinde
             * aranan eğer kullanıcı adı sanal database içerisinde bulunursa field içerisine
             * eklenmek istenen değer eklenemesin.(Kapsülleme)
             * 
             * Müşteri ekle adında static metot oluşturalım. Parametre olarak müsteri tipi
             * alsın. İçerisinde müşeri listesinin null olup olmadığını ve müşteri nesnesi 
             * içerisindeki kullanıcı adının dolu olması şartına baksın.
             * 
             * Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturduğumuz database
             * imize eklemeden önce email adresinden bir kontrol sağlasın eğer sistemde aynı email adresi 
             * ile müşteri değeri var ise eklemesin yok ise sanal database içerisine ilgili nesneyi eklesin.
             */

            Musteri M1 = new Musteri();
            M1.musteriId = 1;
            M1.isim = "Gamze";
            M1.soyisim = "Kural";
            M1.emailAdres = "gamze.kural@hotmail.com";
            M1.KullaniciAdi = "gamze.kural";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);


            Musteri M2 = new Musteri();
            M2.musteriId = 2;
            M2.isim = "Mutlu";
            M2.soyisim = "Ekinci";
            M2.emailAdres = "mutlu.ekinci@hotmail.com";
            M2.KullaniciAdi = "mutlu.ekinci";
            M2.sifre = "2";

            Musteri.MusteriEkle(M2);


            Musteri M3 = new Musteri();
            M3.musteriId = 1;
            M3.isim = "Gamze";
            M3.soyisim = "Kural";
            M3.emailAdres = "gamze.kural@hotmail.com";
            M3.KullaniciAdi = "gamze.kural";
            M3.sifre = "1";

            Musteri.MusteriEkle(M3);

            foreach (Musteri i in Musteri.musteriDatabase)
            {
                Console.WriteLine(i.musteriId);
                Console.WriteLine(i.isim);
                Console.WriteLine(i.soyisim);
                Console.WriteLine(i.KullaniciAdi);
                Console.WriteLine(i.sifre);
                Console.WriteLine(i.emailAdres);

            }
            
            Console.ReadKey();
        }
    }
}
