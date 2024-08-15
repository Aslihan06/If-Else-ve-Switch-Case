using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan meyve ismi al
        Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
        string meyve = Console.ReadLine().ToLower(); // Küçük harfe dönüştür

        // switch ile fiyat belirleme
        switch (meyve)
        {
            case "elma":
                Console.WriteLine("Elma'nın fiyatı: 2 TL");
                break;
            case "armut":
                Console.WriteLine("Armut'un fiyatı: 3 TL");
                break;
            case "çilek":
                Console.WriteLine("Çilek'in fiyatı: 2 TL");
                break;
            case "muz":
                Console.WriteLine("Muz'un fiyatı: 3 TL");
                break;
            default:
                Console.WriteLine("Diğer meyvelerin fiyatı: 4 TL");
                break;
        }
    }
}