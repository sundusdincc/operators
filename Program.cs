internal class Program
{
    private static void Main(string[] args)
    {

        //Temel Atama Operatörü
        Console.WriteLine("Temel Atama Operatörü");
        int numaraBir, numaraIki;
        // Assigning a constant to variable
        numaraBir = 10;
        Console.WriteLine("İlk numara = {0}", numaraBir);

        // Assigning a variable to another variable
        numaraIki = numaraBir;
        Console.WriteLine("İkinci numara = {0}", numaraIki);
        Console.ReadLine();




        //Aritmetik Operatörler
        Console.WriteLine("Aritmetik Operatörler");
        double ilkSayi = 14.40, ikinciSayi = 4.60, result;
        int say1 = 26, say2 = 4, kal;

        // Toplama Operatörü
        result = ilkSayi + ikinciSayi;
        Console.WriteLine("{0} + {1} = {2}", ilkSayi, ikinciSayi, result);

        // Çıkarma Operatörü
        result = ilkSayi - ikinciSayi;
        Console.WriteLine("{0} - {1} = {2}", ilkSayi, ikinciSayi, result);

        // Çarpma Operatörü
        result = ilkSayi * ikinciSayi;
        Console.WriteLine("{0} * {1} = {2}", ilkSayi, ikinciSayi, result);

        // Bölme Operatörü
        result = ilkSayi / ikinciSayi;
        Console.WriteLine("{0} / {1} = {2}", ilkSayi, ikinciSayi, result);

        // Kalan Operatörü
        kal = say1 % say2;
        Console.WriteLine("{0} % {1} = {2}", say1, say2, kal);
        Console.ReadLine();







        //İlişkisel Operatörler
        Console.WriteLine("İlişkisel Operatörler");

        bool sonuc;
        int ilkSayi1 = 10, ikinciSayi1 = 20;

        sonuc = (ilkSayi1 == ikinciSayi1);
        Console.WriteLine("{0} == {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);

        sonuc = (ilkSayi1 > ikinciSayi1);
        Console.WriteLine("{0} > {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);

        sonuc = (ilkSayi1 < ikinciSayi1);
        Console.WriteLine("{0} < {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);

        sonuc = (ilkSayi1 >= ikinciSayi1);
        Console.WriteLine("{0} >= {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);

        sonuc = (ilkSayi1 <= ikinciSayi1);
        Console.WriteLine("{0} <= {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);

        sonuc = (ilkSayi1 != ikinciSayi1);
        Console.WriteLine("{0} != {1} sonuç {2}", ilkSayi1, ikinciSayi1, sonuc);
        Console.ReadLine();







        //Mantıksal Operatörler
        Console.WriteLine("Mantıksal Operatörler");
        bool sonuc1;
        int ilkSayi2 = 10, ikinciSayi2 = 20;

        // VEYA operatörü
        sonuc1 = (ilkSayi2 == ikinciSayi2) || (ilkSayi2 > 5);
        Console.WriteLine(sonuc1);

        // VE operatörü
        sonuc1 = (ilkSayi2 == ikinciSayi2) && (ilkSayi2 > 5);
        Console.WriteLine(sonuc1);
        Console.ReadLine();







        //Tekli Operatörler
        Console.WriteLine("Tekli Operatörler");
        int sayi = 10, sunuc3;
        bool dogruYanlis = true;

        sunuc3 = +sayi;
        Console.WriteLine("+sayi = " + sunuc3);

        sunuc3 = -sayi;
        Console.WriteLine("-sayi = " + sunuc3);

        sunuc3 = ++sayi;
        Console.WriteLine("++sayi = " + sunuc3);

        sunuc3 = --sayi;
        Console.WriteLine("--sayi = " + sunuc3);

        Console.WriteLine("!dogruYanlis = " + (!dogruYanlis));
        Console.ReadLine();








        // Ön Arttırma operatörleri
        Console.WriteLine("Ön Arttırma operatörleri");
        int sayi1 = 10;

        Console.WriteLine((sayi1++));
        Console.WriteLine((sayi1));

        Console.WriteLine((++sayi1));
        Console.WriteLine((sayi1));
        Console.ReadLine();

    }
}