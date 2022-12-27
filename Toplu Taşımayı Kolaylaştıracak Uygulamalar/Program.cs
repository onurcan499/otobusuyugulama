using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplu_Taşımayı_Kolaylaştıracak_Uygulamalar
{
    internal class Program
    {
        static int kullaniciSayisi = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("                                    >>>>> Uygulamamıza HoşGeldiniz <<<<<");
            Console.WriteLine("                          >>>>> Uygulamaya Giriş Yapmak İçin Bir Tuşa Basın <<<<<");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("                                                                                  ");
            Console.WriteLine("-----------             Kapasitesi Dolduğu Zaman Yolcu Almayı Bırakan Uygulama İçin 1'e               -----------");
            Console.WriteLine("                                                                                  ");
            Console.WriteLine("-----------  Kapasitesi Dolduğu Zaman Sisteme Yeni Araç Gerektiğini Yazan Uygulama İçin 2'ye Basınız  -----------");
            string tus=Console.ReadLine();
            if(tus=="1")
            {
                Console.Clear();
                OtobusKapasite();
            }
            else if(tus=="2")
            { 
                Console.Clear();
                YeniAracGelmesi();
            }
            Console.ReadKey();

        }
        static void OtobusKapasite()
        {
            int yolcuSayisi = 0;
            int kapasite = 50;
            int boşKısım = kapasite - yolcuSayisi;
            Console.WriteLine("Otobüsün Kapasitesi: " + kapasite);
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Yolcu Sayısı: " + yolcuSayisi);
                Console.WriteLine($"{i}. Durak");
                Console.WriteLine("Durakta Kaç Kişinin indiğini Yazınız");
                int inecekYolcu = Convert.ToInt32(Console.ReadLine());
                if (inecekYolcu <= yolcuSayisi)
                {
                    yolcuSayisi = yolcuSayisi - inecekYolcu;
                }
                else
                {
                    yolcuSayisi = 0;
                }
                Console.WriteLine("Yolcu Sayısı: " + yolcuSayisi);
                Console.WriteLine("Durakta Kaç kişinin Beklediğini Yazınız");
                int binecekYolcu = Convert.ToInt32(Console.ReadLine());
                if (binecekYolcu + yolcuSayisi <= kapasite)
                {
                    yolcuSayisi = yolcuSayisi + binecekYolcu;
                }
                else if (binecekYolcu+yolcuSayisi > kapasite)
                {
                    int aAAAa = binecekYolcu + yolcuSayisi - 50;
                    yolcuSayisi = kapasite;
                    Console.WriteLine($"Otobüsün Kapasitesi Dolduğu için {aAAAa} kişi durakta kalmıştır.");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            Console.WriteLine($"kullanıcı Otobüsün İçinde {yolcuSayisi} kişi Var. ");
        }
        static void YeniAracGelmesi()
        {
            int yolcuSayisi = 0;
            int kapasite = 50;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"{i}. Durak");
                Console.WriteLine("Durakta Kaç kişinin Beklediğini Yazınız");
                int binecekYolcu = Convert.ToInt32(Console.ReadLine());
                if (binecekYolcu + yolcuSayisi <= kapasite)
                {
                    yolcuSayisi = yolcuSayisi + binecekYolcu;
                }
                else if(binecekYolcu+yolcuSayisi > kapasite)
                {
                    int aAAAa = binecekYolcu + yolcuSayisi-50;
                    yolcuSayisi = kapasite;
                    Console.WriteLine($"Otobüsün Kapasitesi Dolduğu için {aAAAa} kişi durakta kalmıştır.");
                    Console.WriteLine($"{i}. Durağa Giden Otobüs Seferleri Arttırılmalıdır.");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}