using System;
using System.Collections.Generic;

class StudentGrades
{
    private Dictionary<string, double> grades = new Dictionary<string, double>();

    // Ders adına göre not erişim
    public double this[string course]
    {
        get
        {
            if (!grades.ContainsKey(course))
                throw new KeyNotFoundException("Ders bulunamadı.");
            return grades[course];
        }
        set
        {
            grades[course] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentGrades student = new StudentGrades();

        // Ders notlarını ekliyoruz
        student["Math"] = 85.5;
        student["Physics"] = 92.0;

        // Ders notlarını yazdırıyoruz
        Console.WriteLine(student["Math"]); // Output: 85.5
        Console.WriteLine(student["Physics"]); // Output: 92.0

        // Geçersiz ders örneği
        try
        {
            Console.WriteLine(student["Chemistry"]); // Hata: Ders bulunamadı.
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
