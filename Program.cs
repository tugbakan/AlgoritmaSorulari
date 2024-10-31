using System;

public class Program
{
    public static void Main(string[] args)
    {

      /* ÖRNEK1= Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı 
girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
        Console.Write("Lütfen kaç elemanlı dizi oluşturacağınızı yazınız.");
    int n = int.Parse(Console.ReadLine());

    int[] dizi= new int[n];

        for (int i = 0; i < n; i++)
        {   Console.WriteLine("Lütfen dizinin " + (i + 1) + ". elemanını giriniz.");
            dizi[i]= int.Parse(Console.ReadLine());
        }
        foreach (var sayi in dizi)
        {
            if (sayi%2==0)
                 Console.Write(sayi + " ");
        }  

    /* ÖRNEK2= Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı
    girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */
    
    Console.Write("Lütfen kaç elemanlı dizi oluşturacağınızı yazınız.");
    int n2 = int.Parse(Console.ReadLine());
    Console.Write("Lütfen kaça tam bölüneceğini merak ettiğiniz sayıyı giriniz.");
    int m2 = int.Parse(Console.ReadLine());

    int[] dizi2= new int[n2];

    for (int i = 0; i < n2; i++)
    {   
        Console.WriteLine("Lütfen dizinin " + (i + 1) + ". elemanını giriniz.");
        dizi2[i]= int.Parse(Console.ReadLine());
    }

    foreach (int a in dizi2)
    {
        if (a%m2==0)
        Console.Write(a + " ");
    }
    

    /*ÖRNEK3= Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime 
    girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */
    
    
    Console.Write("Lütfen kaç elemanlı dizi oluşturacağınızı yazınız.");
    int n3 = int.Parse(Console.ReadLine());
    string[] dizi3= new string[n3];

    for (int i = 0; i < n3; i++)
    {   
        Console.WriteLine("Lütfen dizinin " + (i + 1) + ". elemanını giriniz.");
        dizi3[i]= Console.ReadLine();
    }

    Array.Reverse(dizi3);

    foreach (string kelime in dizi3)
    {
        Console.WriteLine(kelime);        
    }
    

    /*ÖRNEK4= Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a 
    yazdırın. */

    Console.Write("Lütfen bir cümle yazınız");
    string cumle = Console.ReadLine();

    int bosluksayisi=0;
    int harfsayisi=0;

    foreach (char karakter in cumle)
    {
        if (karakter==' ')
        {
            bosluksayisi++;
        }
        else
        {
            harfsayisi++;
        }
    }

    Console.WriteLine("Kelime Sayisi=" + (bosluksayisi+1));
    Console.WriteLine("Harf Sayısı=" + harfsayisi);
    
    }
}

