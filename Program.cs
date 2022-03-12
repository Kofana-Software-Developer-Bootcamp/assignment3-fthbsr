using System;
using System.Collections.Generic;

namespace bus_app
{
    class Program
    {
        static  void  Main(string[] args)
        {
            int id = 0 ;
            List<Yolcu> yolcular  = new List<Yolcu>();
            List<Sefer> seferler = new List<Sefer>();
            bool donsunMu = true;


            while(donsunMu)
            {
            Console.WriteLine("Yapmak Istediniz Islemin Numarasini Giriniz:");
            Console.WriteLine(" 1-)Bilet Al\n 2-)Bilet Iptal\n 3-)Sefer Bilgileri\n4-) Cikis  ");
            int input =Convert.ToInt32(Console.ReadLine());

            switch (input)
                {
                    case 1 :
                    Console.WriteLine("Lutfen adinizi , soyadinizi , dogum yilinizi ve gidiceginiz sehri \"-\" koyarak giriniz.");
                        string value = Console.ReadLine();
                        id ++;
                        Yolcu y1 = new Yolcu 
                        {
                            Id = id,
                            Isim = value.Split('-')[0],
                            Soyad = value.Split('-')[1],
                            DogumYili = Convert.ToInt32(value.Split('-')[2]),
                            GidilicekSehir = value.Split('-')[3]
                        };
                        yolcular.Add(y1);
                        Console.WriteLine(" Yolcu ID'niz {0} olan {1} seferi biletiniz olusturulmustur.\n" ,  y1.Id  , y1.GidilicekSehir );
                        break;
                    case 2 :
                        Console.WriteLine("Lutfen Iptal etmek istediginiz biletin ID'sini giriniz :");
                        int CancelId =Convert.ToInt32(Console.ReadLine());
                        yolcular.RemoveAt(CancelId -1 );
                        Console.WriteLine("Sayin yolcumuz {0} ID'li biletiniz iptal edilmistir ... " , CancelId);
                        break;
                    case 3 : 
                    Sefer s1 = new Sefer
                    {
                        terminalNo = 1 ,
                        sehir = "Trabzon",
                        zaman = 13 ,
                        km = 1200,

                    };
                    Sefer s2 = new Sefer
                    {
                        terminalNo = 2 ,
                        sehir = "Antalya",
                        zaman = 9 ,
                        km = 700,

                    };
                     Sefer s3 = new Sefer
                    {
                        terminalNo = 3 ,
                        sehir = "Ankara",
                        zaman = 6 ,
                        km = 500,

                    };

                    seferler.Add(s1);
                    seferler.Add(s2);
                    seferler.Add(s3);



                   

                    foreach (var sefer in seferler)
                    {
                        Console.WriteLine("Terminal Numarasi" + sefer.terminalNo  + " olan " +  sefer.sehir + " seferi " + sefer.zaman + " saat surucekti  ve tahmini yolculuk " + sefer.km + " km'dir." );
                    }
                    

                        break;
                    case 4 : 
                        Console.WriteLine("Sistemden Cikiliyor .. ");
                        System.Threading.Thread.Sleep(500);
                        donsunMu = false;

                        break;
                    default:
                    break;
                }
        }
    }

    public class Yolcu  
        {
            public int Id {get; set; }
            public string  Isim {get; set; }
            public string Soyad {get; set; }
            public int DogumYili {get; set; }
            public string GidilicekSehir {get; set; }

            
            
        }

    public class Sefer
    {
        public int terminalNo {get; set; }
        public string  sehir {get; set; }
        public int zaman {get; set; }
        public int km {get; set; }
    }


    }    
}