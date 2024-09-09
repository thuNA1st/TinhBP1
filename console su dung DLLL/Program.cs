using System;
using System.Text;
using SquareCalculator; // Nhập không gian tên của DLL

class Program
{
    static void Main()
    {
        // Đặt mã hóa đầu ra của Console là UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo đối tượng Calculator từ DLL
        Calculator calc = new Calculator();

        // Nhập một số từ bàn phím
        Console.Write("Nhập một số: ");
        string input = Console.ReadLine();

        // Chuyển đổi chuỗi nhập vào thành số thực (double)
        double number;
        if (double.TryParse(input, out number))
        {
            // Tính bình phương của số
            double square = calc.CalculateSquare(number);

            // Hiển thị kết quả
            Console.WriteLine($"Bình phương của {number} là {square}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số hợp lệ.");
        }
    }
}
