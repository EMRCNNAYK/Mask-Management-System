using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "Engin");
SelamVer(isim: "Ahmet");
SelamVer(isim: "Ayşe");
SelamVer();

int sonuc = Topla(6, 58);

//Diziler Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "EMİR";
person1.LastName = "CAN";
person1.DateOfBirthYear = 1997;
person1.NationalIdentity = 12345678910;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
//Mylist
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add(item: "Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager()); //!!
pttManager.GiveMask(person1);

Console.ReadLine();

//resharper

static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}
static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}