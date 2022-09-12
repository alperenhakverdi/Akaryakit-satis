using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitSatis
{
    class Program
    {

        static void Main(string[] args)
        {
            anamenu();
            Console.ReadLine();
        }

        //Fiyatlar
        public static double dizel = 13;
        public static double benzin = 14;
        public static double lpg = 10;

        // Akaryakıt başlangıç miktarları

        public static double dizelbas = 1000;
        public static double benzinbas = 1000;
        public static double lpgbas = 1000;


        //Akaryakıt miktarları

        public static double dizeldurum = 1000;
        public static double benzindurum = 1000;
        public static double lpgdurum = 1000;

        //
        public static int alinacakyakit;
         

        static void anamenu()
        {
            secimyap:
            Console.WriteLine("AKARYAKIT SATIŞ TAKİP");
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("1-Birim Fiyatı Göster");
            Console.WriteLine("2-Birim Fiyatı Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı Yap");
            Console.WriteLine("4-Depo Durumu Göster");
            Console.WriteLine("5-Toplam Satışları Göster");
            Console.WriteLine("6-Çıkış");
            Console.Write("Seçiminizi yapınız (1-2-3-4-5-6)");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    Console.Clear();
                    fiyatgoster();
                    break;
                case '2':
                    Console.Clear();
                    fiyatguncelle();
                    break;
                case '3':
                    Console.Clear();
                    satisyap();
                    break;
                case '4':
                    Console.Clear();
                    depodurumu();
                    break;
                case '5':
                    Console.Clear();
                    toplamsatis();
                    break;
                case '6':
                    Console.WriteLine("Çıkış yapmak istediğinize emin misiniz ? (E-H)");
                    char cikis = Convert.ToChar(Console.ReadLine());
                    if (cikis=='E' || cikis =='e' )
                    {
                        Environment.Exit(0);
                    }
                    else if (cikis=='H' || cikis=='h')
                    {
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        Console.Clear();
                        anamenu();
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Geçersiz karakter girişi, tekrar seçim yapınız.");
                    Console.WriteLine();
                    goto secimyap;
                    break;
            }
        }
        static void anamenudon()
        {
            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();
            anamenu();
        }
        
        static void fiyatgoster()
        {
            Console.WriteLine("---Birim Fiyatlar Listesi---");
            Console.WriteLine("Dizel (D) {0} TL/Litre ",dizel);
            Console.WriteLine("Benzin (B) {0} TL/Litre ",benzin);
            Console.WriteLine("LPG (L) {0} TL/Litre ",lpg);
            anamenudon();
        }

        static void fiyatguncellemedevam()
        {
            Console.WriteLine("Devam etmek istiyor musunuz? (E-H)");
            char devam = Convert.ToChar(Console.ReadLine());
            if (devam == 'E' || devam == 'e')
            {
                Console.Clear();
                fiyatguncelle();
            }
            else if (devam == 'H' || devam == 'h')
            {
                anamenudon();
            }
        }
        static void fiyatguncelle()
        {
            fiyatguncelleme:
            Console.WriteLine("---Birim Fiyatlar Güncelle---");
            Console.WriteLine("Akaryakıt Tipini seçin (D/B/L)");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case 'D':
                    Console.WriteLine("Dizel (D) {0} TL/Litre ", dizel);
                    Console.WriteLine("Dizelin yeni fiyatını giriniz.");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Dizel (D) {0} TL/Litre ", dizel);
                    fiyatguncellemedevam();
                    break;
                case 'B':
                    Console.WriteLine("Benzin (B) {0} TL/Litre ", benzin);
                    Console.Write("Benzinin yeni fiyatını giriniz.");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Benzin (B) {0} TL/Litre ", benzin);
                    fiyatguncellemedevam();
                    break;
                case 'L':
                    Console.WriteLine("LPG (L) {0} TL/Litre ", lpg);
                    Console.Write("LPG'nin yeni fiyatını giriniz.");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    fiyatguncellemedevam();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("(D/B/L) dışında hatalı seçim yaptınız!");
                    Console.WriteLine();
                    goto fiyatguncelleme;
                    break;
            }
        }

        static void satisdevam()
        {
            Console.WriteLine("Devam etmek istiyor musunuz? (E-H)");
            char devam = Convert.ToChar(Console.ReadLine());
            if (devam == 'E' || devam == 'e')
            {
                Console.Clear();
                satisyap();
            }
            else if (devam == 'H' || devam == 'h')
            {
                anamenudon();
            }
        }
        
        static void  satisyap()
        {
            satisdevam:
            Console.WriteLine("---Akaryakıt Satışı---");
            Console.WriteLine("Akaryakıt tipini seçiniz (D/B/L)");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case 'D':
                    yakitgiris2:
                    Console.WriteLine("Ne kadarlık dizel yakıt alacaksınız ? ");
                    alinacakyakit = Convert.ToInt32(Console.ReadLine());
                    if (alinacakyakit > benzindurum)
                    {
                        Console.WriteLine("Elimizde {0} Litre Dizel  yoktur maksimum {1} litre " +
                            "alabilirsiniz yeniden bir tutar girmek için bir tuşa basınız" +
                            "", alinacakyakit, dizeldurum);
                        Console.ReadKey();
                        goto yakitgiris2;
                    }
                    dizeldurum = dizeldurum - alinacakyakit;
                    Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                    Console.WriteLine("Yakıt tankında {0} Litre dizel yakıt kaldı.", dizeldurum);
                    satisdevam();
                    break;
                case 'B':
                    yakitgiris:
                    Console.WriteLine("Ne kadarlık Benzin  alacaksınız ? ");
                    alinacakyakit = Convert.ToInt32(Console.ReadLine());
                    if (alinacakyakit>benzindurum)
                    {
                        Console.WriteLine("Elimizde {0} Litre benzin yoktur maksimum {1} litre " +
                            "alabilirsiniz yeniden bir tutar girmek için bir tuşa basınız" +
                            "",alinacakyakit,benzindurum);
                        Console.ReadKey();
                        goto yakitgiris;
                    }
                    benzindurum = benzindurum - alinacakyakit;
                    Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                    Console.WriteLine("Yakıt tankında {0} Litre benzin kaldı.", benzindurum);
                    satisdevam();
                    break;
                case 'L':
                    yakitgiris3:
                    Console.WriteLine("Ne kadarlık LPG  alacaksınız ? ");
                    alinacakyakit = Convert.ToInt32(Console.ReadLine());
                    if (alinacakyakit > benzindurum)
                    {
                        Console.WriteLine("Elimizde {0} Litre LPG yoktur maksimum {1} litre " +
                            "alabilirsiniz yeniden bir tutar girmek için bir tuşa basınız" +
                            "", alinacakyakit, lpgdurum);
                        Console.ReadKey();
                        goto yakitgiris3;
                    }
                    lpgdurum = lpgdurum - alinacakyakit;
                    Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                    Console.WriteLine("Yakıt tankında {0} Litre LPG kaldı.", lpgdurum);
                    satisdevam();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("(D/B/L) dışında seçim yaptınız !");
                    Console.WriteLine();
                    goto satisdevam;
                    break;
            }
        }

        static void depodurumu()
        {
            Console.WriteLine("---Depo Durumu---");
            double dizelyuzde = (dizeldurum / dizelbas) * 100;
            double benzinyuzde = (benzindurum / benzinbas) * 100;
            double lpgyuzde = (lpgdurum / lpgbas) * 100;

        Console.WriteLine("Dizel tankı %{0} doludur.",dizelyuzde);
            Console.WriteLine("Benzin tankı %{0} doludur.",benzinyuzde);
            Console.WriteLine("LPG tankı %{0} doludur.",lpgyuzde);
            anamenudon();
        }
        
        static void toplamsatis()
        {
            Console.WriteLine("---Toplam Satış Durumu---");
            double dizelsatismiktari = dizelbas - dizeldurum;
            Console.WriteLine("Satılan toplam dizel yakıt :{0}",dizelsatismiktari);
            double dizelkazanc = dizel * dizelsatismiktari;
            Console.WriteLine("Tutarı: {0}",dizelkazanc);
            double benzinsatismiktari = benzinbas - benzindurum;
            Console.WriteLine("Satılan toplam Benzin yakıt :{0}",benzinsatismiktari);
            double benzinkazanc = benzin * benzinsatismiktari;
            Console.WriteLine("Tutarı: {0}",benzinkazanc);
            double lpgsatismiktari = lpgbas - lpgdurum;
            Console.WriteLine("Satılan toplam lpg yakıt :{0}",lpgsatismiktari);
            double lpgkazanc = lpg * lpgsatismiktari;
            Console.WriteLine("Tutarı: {0}",lpgkazanc);
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Topalm tutarı :{0}",dizelkazanc+benzinkazanc+lpgkazanc);
            anamenudon();
        }

    }
}
