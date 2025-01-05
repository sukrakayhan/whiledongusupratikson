//soru1  Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
using System.ComponentModel.Design;

int i = 0;
while (i < 10)
{
    Console.WriteLine("kendime güveniyorum ben bu yazılım işini hallederim");
    i++;
}


//soru 2 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;

}

// soru 3 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int b = 1;
while (b <= 20)
{
    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }
    b++;
}

//soru 4 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;
int c = 50;

while (c <= 150)
{
    toplam = toplam + c;
    c++;
}
Console.WriteLine(toplam);

//soru 5 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int teksayiToplam = 0;
int ciftsayiToplam = 0;
int d = 1;
while (d < 120)
{

    if (d % 2 == 1)
     teksayiToplam = teksayiToplam + d;
    d++;
    }

    Console.WriteLine("tek sayıların toplamı:" + teksayiToplam);
{ if (d % 2 == 0)
        ciftsayiToplam = ciftsayiToplam + d;
    d++;
    Console.WriteLine("çift sayıların toplamı:" + ciftsayiToplam);
    
        }

    