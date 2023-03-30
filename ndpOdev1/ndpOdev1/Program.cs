/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: MERT ESER MERAL
**				ÖĞRENCİ NUMARASI.......: G211210047
**              DERSİN ALINDIĞI GRUP...: IO-B 
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpOdev1
{
    public static class SifreGuvenlik   // Sifredeki karakter sayıları ile ilgili islemleri yapacak sinif.
    {
        public static string parola;
        public static int buyukHarfSayısı = 0;
        public static int buyukHarfPuan = 0;
        public static int kucukHarfSayısı = 0;
        public static int kucukHarfPuan = 0;
        public static int rakamSayısı = 0;
        public static int rakamPuan = 0;
        public static int sembolSayısı = 0;
        public static int sembolPuan = 0;
        public static void rakam() // Sifre icinde rakam olup olmadığını kontrol eden method.
        {
            char[] rakamlar = { '1', '2', '3', '4', '5', '6', '7', '8', '9','0' };
            for (int k = 0; k < rakamlar.Length; k++)  // Donguyu rakamlar dizisinin eleman sayısı kadar donduren for dongusu.
            {
                for (int i = 0; i < parola.Length; i++) //Donguyu sifre uzunlugu kadar donduren for dongusu.
                {
                    if (parola[i] == rakamlar[k])
                    {
                        rakamSayısı++;
                        if (rakamPuan < 20)//puan sinirlama kismi.
                        {
                            rakamPuan+=10;
                        }
                    }
                }
            }
            Console.WriteLine("Girmis oldugunuz sifredeki rakam sayisi : " + rakamSayısı);
        }
        public static void buyukHarf() // Sifre icindeki buyuk harfleri kontrol eden method.
        {
            char[] buyukHarfler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G','Ğ', 'H', 'I','İ', 'J', 'K', 'L', 'M', 'N', 'O','Ö', 'P', 'Q', 'R', 'S','Ş', 'T', 'U','Ü', 'V', 'W', 'X', 'Y', 'Z' };

            for (int k = 0; k < buyukHarfler.Length; k++) // Donguyu buyukHarfler dizisinin eleman sayısı kadar döndürür.
            {
                for (int i = 0; i < parola.Length; i++)   //Donguyu sifre uzunlugu kadar dondurur.
                {
                    if (parola[i] == buyukHarfler[k])
                    {
                        buyukHarfSayısı++;
                        if (buyukHarfPuan < 20)//puan sinirlama kismi.
                        {
                            buyukHarfPuan+=10;
                        }
                    }
                }
            }
            Console.WriteLine("Girmis oldugunuz sifredeki buyuk harf sayisi : " + buyukHarfSayısı);
        }
        public static void kucukHarf() // Sifrede kucuk harf olup olmadığını kontrol eden method.
        {
            char[] kucukHarfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g','ğ', 'h','ı','i', 'j', 'k', 'l', 'm', 'n', 'o','ö','p', 'q', 'r', 's','ş', 't', 'u','ü', 'v', 'w', 'x', 'z'};

            for (int k = 0; k < kucukHarfler.Length; k++) // Donguyu kucukHarfler dizisinin eleman sayısı kadar döndürür.
            {
                for (int i = 0; i < parola.Length; i++)   //Donguyu sifre uzunlugu kadar dondurur.
                {
                    if (parola[i] == kucukHarfler[k])
                    {
                        kucukHarfSayısı++;
                        if (kucukHarfPuan < 20)//puan sinirlama kismi.
                        {
                            kucukHarfPuan+=10;
                        }
                    }
                }
            }
            Console.WriteLine("Girmis oldugunuz sifredeki kucuk harf sayisi : " + kucukHarfSayısı);
        }
        public static void sembol() // Sifre icinde sembol olup olmadığının kontol eden method.
        {
            char[] semboller = { '.', ',', ':', '?', '=', '-', '(', ')', '"', '/', '%', '@', '!','*','+','£','>','^','#','$','½','&','_','|','<','{','}','[',']','é','€' };

            for (int k = 0; k < semboller.Length; k++) //Donguyu semboller dizisinin eleman sayısı kadar dondurur.
            {
                for (int i = 0; i < parola.Length; i++) //Donguyu sifre uzunlugu kadar donduren for dongusu.
                {
                    if (parola[i] == semboller[k])
                    {
                        sembolSayısı++;
                        sembolPuan += 10;
                    }
                }
            }
            Console.WriteLine("Girmis oldugunuz sifredeki sembol sayisi : " + sembolSayısı);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sifre Guvenlik Testi Uygulamasi");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            
            int guvenlikPuani = 0;
            string harf;
            bool bosluk = true;
            do
            {
                do
                {
                    Console.WriteLine("Lutfen guvenlik testi yapmak istediginiz sifreyi giriniz.");
                    Console.Write("Sifre : ");
                    SifreGuvenlik.parola = Console.ReadLine();
                    for (int i = 0; i < SifreGuvenlik.parola.Length; i++)
                    {
                        if (SifreGuvenlik.parola[i] == ' ')
                        {
                            bosluk = false;
                        }
                    }
                    SifreGuvenlik.rakam();
                    SifreGuvenlik.buyukHarf();
                    SifreGuvenlik.kucukHarf();
                    SifreGuvenlik.sembol();             
                    if (SifreGuvenlik.parola.Length >= 9 && bosluk == true&& SifreGuvenlik.rakamSayısı != 0 && SifreGuvenlik.buyukHarfSayısı != 0 && SifreGuvenlik.kucukHarfSayısı != 0 && SifreGuvenlik.sembolSayısı != 0)
                    { //sifrenin gerekli kosullari gectiginde puanlamaya girdigi if blogu.
                        
                        
                           
                            guvenlikPuani = SifreGuvenlik.rakamPuan + SifreGuvenlik.kucukHarfPuan + SifreGuvenlik.buyukHarfPuan + SifreGuvenlik.sembolPuan + 10;
                            Console.WriteLine("Sifrenizin guvenlik puani : " + guvenlikPuani);
                            if (guvenlikPuani < 70)
                            {
                                Console.WriteLine("Sifre yeterince guclu degil.");
                            }
                            else if (guvenlikPuani <= 90 && guvenlikPuani >= 70)
                            {
                                Console.WriteLine("Sifre normal düzeyde, güvenli.");
                            }
                            else if (guvenlikPuani < 100 && guvenlikPuani >= 90)
                            {
                                Console.WriteLine("Sifre güclü düzeyde, güvenli.");
                            }
                            else
                            {
                                Console.WriteLine("Sifre cok guclu.");
                            }
                        
                    }
                    else
                    {
                        if (SifreGuvenlik.parola.Length <= 9 || bosluk == false || guvenlikPuani < 70) //sifrenin zayif oldugu durumlarda girilen if blogu.
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Sifre zayıf, güvenli değil.Lütfen tekrar deneyiniz.\nSifre minimum 9 karaktere sahip olmalı\nSifre bosluk icermemeli\nSembol,rakam,buyuk harf ve kucuk harften en az birer tane icermeli.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.Write("Lutfen tekrar sifre giriniz : ");
                        }
                    }
                    break;
                } 
                while (SifreGuvenlik.parola.Length < 9 || bosluk == false || guvenlikPuani < 70);//kullaniciya yeniden sifre girme secenegi sunan do while kismi.
                Console.WriteLine("Baska bir sifre test etmek ister misiniz?(y/n)");
                harf = Console.ReadLine();
                if (harf == "y")//eger kullanici tekrar sifre girmek isterse eski sifrenin verileri buradaki if sayesinde sifirlaniyor.
                {
                    SifreGuvenlik.sembolSayısı = 0;
                    SifreGuvenlik.sembolPuan = 0;
                    SifreGuvenlik.rakamSayısı = 0;
                    SifreGuvenlik.rakamPuan = 0;
                    SifreGuvenlik.kucukHarfSayısı = 0;
                    SifreGuvenlik.kucukHarfPuan = 0;
                    SifreGuvenlik.buyukHarfSayısı = 0;
                    SifreGuvenlik.buyukHarfPuan = 0;
                }
            } while (harf == "y");
        }
    }
}