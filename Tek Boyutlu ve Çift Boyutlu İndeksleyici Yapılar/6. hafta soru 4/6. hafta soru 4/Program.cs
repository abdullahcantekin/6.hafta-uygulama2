using System;

class BookLibrary
{
    private string[] books = new string[5]; // 5 kitaplık koleksiyon

    // Kitapları indeksleyici ile erişim sağlıyoruz
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= books.Length)
                throw new IndexOutOfRangeException("Geçersiz indeks.");
            return books[index];
        }
        set
        {
            if (index < 0 || index >= books.Length)
                throw new IndexOutOfRangeException("Geçersiz indeks.");
            books[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        BookLibrary library = new BookLibrary();

        // Kitap ekliyoruz
        library[0] = "C# Guide";
        library[1] = "Data Structures";
        library[2] = "Algorithms";

        // Kitap adlarını ekrana yazdırıyoruz
        Console.WriteLine(library[0]); // Output: C# Guide
        Console.WriteLine(library[1]); // Output: Data Structures

        // Geçersiz indeks örneği
        try
        {
            Console.WriteLine(library[5]); // Hata: Geçersiz indeks.
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

