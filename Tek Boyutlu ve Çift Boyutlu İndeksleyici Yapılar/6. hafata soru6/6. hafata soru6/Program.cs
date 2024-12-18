using System;

class ChessBoard
{
    private string[,] board = new string[8, 8]; // 8x8 satranç tahtası

    // Satranç tahtasında kareye taş yerleştirme ve okuma
    public string this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= 8 || col < 0 || col >= 8)
                throw new IndexOutOfRangeException("Geçersiz kare.");
            return board[row, col] ?? "Boş"; // Eğer taş yoksa "Boş" döndür
        }
        set
        {
            if (row < 0 || row >= 8 || col < 0 || col >= 8)
                throw new IndexOutOfRangeException("Geçersiz kare.");
            board[row, col] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        ChessBoard chessBoard = new ChessBoard();

        // Taşları yerleştiriyoruz
        chessBoard[0, 0] = "Rook"; // Kale
        chessBoard[0, 1] = "Knight"; // Şövalye
        chessBoard[7, 7] = "King"; // Kral

        // Taşları yazdırıyoruz
        Console.WriteLine(chessBoard[0, 0]); // Output: Rook
        Console.WriteLine(chessBoard[7, 7]); // Output: King

        // Geçersiz kare örneği
        try
        {
            Console.WriteLine(chessBoard[8, 8]); // Hata: Geçersiz kare.
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
