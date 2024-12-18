using System;

class ParkingLot
{
    private string[,] floors = new string[3, 5]; // 3 kat, 5 park yeri

    // Park yerlerine erişim sağlıyoruz
    public string this[int floor, int spot]
    {
        get
        {
            if (floor < 0 || floor >= 3 || spot < 0 || spot >= 5)
                throw new IndexOutOfRangeException("Geçersiz park yeri.");
            return floors[floor, spot] ?? "Empty"; // Park yeri boşsa "Empty" döndür
        }
        set
        {
            if (floor < 0 || floor >= 3 || spot < 0 || spot >= 5)
                throw new IndexOutOfRangeException("Geçersiz park yeri.");
            floors[floor, spot] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        ParkingLot parkingLot = new ParkingLot();

        // Park yerlerine araç ekliyoruz
        parkingLot[0, 0] = "ABC123"; // Araç plakası
        parkingLot[1, 2] = "XYZ789";

        // Park yerlerini yazdırıyoruz
        Console.WriteLine(parkingLot[0, 0]); // Output: ABC123
        Console.WriteLine(parkingLot[1, 2]); // Output: XYZ789
        Console.WriteLine(parkingLot[2, 4]); // Output: Empty

        // Geçersiz park yeri örneği
        try
        {
            Console.WriteLine(parkingLot[3, 5]); // Hata: Geçersiz park yeri.
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

