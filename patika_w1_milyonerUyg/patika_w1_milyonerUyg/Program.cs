using System;

namespace Milyoner
{
    class Program
    {


        static void Main(string[] args)
        {
            
            string answer; //Cevapları String ifade olarak alıyorum
            int score = 0; //sonuç için bir skor tutuyorum

            Console.WriteLine("Bilgi Yarışmamıza Hoşgeldiniz... \n3 Adet Sorumuz Vardır.");

            Console.WriteLine("1.Soru : Kızınca Tüküren Hayvan Aşağıdakilerden Hangisidir?"); //1.Soru
            Console.WriteLine("A - Lama");
            Console.WriteLine("B - Deve");
            Console.Write("Cevabınız A/B:\n");
            answer = Console.ReadLine().ToUpper();

            switch (answer) //switch case yapısı ile sorunun cevabını alıyorum
            {
                case "A":
                    score++; //eğer doğru cevap verilirse skor 1 artıcak ve sonraki soruya geçeceğiz
                    Console.WriteLine("TEBRİKLER! Doğru Cevap");
                    break;
                case "B":
                    Console.WriteLine("YANLIŞ! Cevap: Lama");
                    break;
                default:
                    Console.WriteLine("Geçersiz Cevap");
                    break;
            }
            Console.WriteLine("\n*********************************************\n");

            Console.WriteLine("2.Soru : Dünya'ya en yakın gezegen hangisidir?"); //2. soru 
            Console.WriteLine("A - Venüs");
            Console.WriteLine("B - Mars");
            Console.Write("Cevabınız A/B:\n");
            answer = Console.ReadLine().ToUpper();

            switch (answer)
            {
                case "A":
                    Console.WriteLine("\nTEBRİKLER! Doğru Cevap");
                    score++; //eğer bu soru da bilinirse skor 1 daha artacak ve 3. soruya geçecek
                    break;
                case "B":
                    Console.WriteLine("YANLIŞ! Cevap: Venüs");
                    break;
                default:
                    Console.WriteLine("Geçersiz Cevap");
                    break;
            }
            Console.WriteLine("\n*********************************************\n");

            if (score >=1) //skoru kontrol ediyorum. İlk 2 sorudan 1 ve daha üstü doğru cevabı varsa 3. Soruyu görecek
            {
                Console.WriteLine("3.Soru : 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
                Console.WriteLine("A - 7");
                Console.WriteLine("B - 12");
                Console.Write("Cevabınız A/B:\n");
                answer = Console.ReadLine().ToUpper();

                switch (answer)
                {
                    case "A": //3.soruda A şıkkını seçerse ekranda kaybettiniz yazacak ve doğru cevap sayısı 1 olarak gözükecek.
                        Console.WriteLine("YANLIŞ! Doğru Cevap:12");
                        Console.WriteLine($"MAALESEF KAYBETTİNİZ.\nDoğru cevap sayınız : {score}");
                        break;
                    case "B":
                        Console.WriteLine("TEBRİKLER! Doğru Cevap");
                        score++; //Eğer doğru cevaplarsa minimum 2 cevabı doğru olacak ve yarışmayı kazanacak. Doğru sayısı ekranda gözükecek.
                        Console.WriteLine($"TEBRİKLER. 1 MİLYON'LUK ÖDÜLÜ KAZANDINIZZ.\nDoğru Cevap Sayınız : {score}");
                        break;
                    default:
                        Console.WriteLine("Geçersiz Cevap");
                        break;
                }

            }
            else //Eğer ilk iki soruda doğru cevabı yoksa direkt else bloğuna girecek ve 3. soruyu göremicektir.
            {
                Console.WriteLine("Maalesef 2 Soruya yanlış cevap verdiniz.");
                Environment.Exit(0);
            }
            
            Console.ReadKey();
        }
    }
}