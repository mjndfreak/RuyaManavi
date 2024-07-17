//Giriş cümlelerini yazdırır.
Console.WriteLine("Rüya manavına hoşgeldiniz!!");
Console.WriteLine("Rüya manavında fiyatlar çok ucuz!");
Console.WriteLine("Elma 2TL");
Console.WriteLine("Armut 3TL");
Console.WriteLine("Çilek 2TL");
Console.WriteLine("Muz 3TL");
Console.WriteLine("Diğerleri 4TL");

Console.Write("Satın almak istediğiniz meyvenin adını giriniz:");
//inputu alır ve küçük harfe çevirir.
string fruit = Console.ReadLine();
string lowerFruit = fruit.ToLower();

//koşulları sağladığında belirli çıktıları alır.
if (lowerFruit == "elma")
{
    Console.WriteLine("Meyvenin fiyatı: 2TL");
}

else if (lowerFruit == "armut")
{
    Console.WriteLine("Meyvenin fiyatı: 3TL");
}

else if (lowerFruit == "çilek")
{
    Console.WriteLine("Meyvenin fiyatı: 2TL");
}

else if (lowerFruit == "muz")
{
    Console.WriteLine("Meyvenin fiyatı: 3TL");
}

else
{
    Console.WriteLine("Meyvenin fiyatı: 4TL");
}


Console.WriteLine("<--------------CaseSwitchCode-------------->");

Console.Write("Satın almak istediğiniz meyvenin adını giriniz:");

string fruit2 = Console.ReadLine();
string lowerFruit2 = fruit.ToLower();

switch (lowerFruit)
{
    case "elma":
        Console.WriteLine("Meyvenin fiyatı: 2TL");
        break;

    case "armut":
        Console.WriteLine("Meyvenin fiyatı: 3TL");
        break;

    case "çilek":
        Console.WriteLine("Meyvenin fiyatı: 2TL");
        break;
    case "muz":
        Console.WriteLine("Meyvenin fiyatı: 3TL");
        break;
    default:
        Console.WriteLine("Meyvenin fiyatı: 4TL");
        break;
}



