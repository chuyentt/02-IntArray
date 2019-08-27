using System;

namespace IntArray
{
  class Program
  {
    /// <summary>
    /// 4080105 - Lập trình .NET 1 + BTL
    /// GV: Trần Trung Chuyên, email: trantrungchuyen@humg.edu.vn
    /// 02. IntArray - Các phép toán với mảng số nguyên
    /// Mục tiêu:
    /// - Biết cách khai báo và sử dụng mảng một chiều cố định
    /// - Biết sử dụng vòng lặp foreach
    /// - Biết cách khai báo và sử dụng mảng hai chiều cố định
    /// - Ôn lại điều kiện rẽ nhánh
    /// - Biết trình bày kết quả ra màn hình
    /// - Biết sử dụng biến thường và biển mảng
    /// </summary>
    /// <param name="args">Tham số khi chạy chương trình</param>
    static void Main(string[] args)
    {
      // Mã hóa output theo Unicode
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      Console.WriteLine("Mảng số nguyên trong C#\r");
      Console.WriteLine("------------------------\n");

      // Khai báo mảng cố định và gán dữ liệu ban đầu
      int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 17 };

      // In ra số phần tử của mảng
      Console.WriteLine($"Số phần tử của mảng là: {numbers.Length}\n");

      // In ra giá trị của từng phần tử
      Console.WriteLine($"Giá trị của từng phần tử:");
      foreach (int number in numbers)
      {
        Console.Write($"{number} ");
      }

      // In ra tổng các giá trị chẵn
      int total = 0;
      foreach (int number in numbers)
      {
        if (number % 2 == 0)
        {
          total += number;
        }
      }
      Console.WriteLine();

      Console.Write($"\nTổng các giá trị phần tử chẵn: {total}\n");

      // Khai báo mảng hai chiều cố định
      int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

      // In ra màn hình ma trận
      Console.WriteLine($"\nMa trận cho trước:");
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
      }

      // Tính tổng các phần tử ma trận tam giác trên
      int sum = 0;
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          if (i <= j) // Điều kiện tam giác trên (cả đường chéo)
          {
            sum += matrix[i, j];
          }
        }
      }

      // In ra màn hình ma trận tam giác trên
      Console.WriteLine($"\nMa trận tam giác trên:");
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          if (i <= j) // Nếu thuộc tam giác trên
            Console.Write($"{matrix[i, j]}\t"); // In ra phần tử và dấu tab
          else
            Console.Write($" \t"); // In ra ký tự trắng và dấu tab
        }
        Console.WriteLine(); // In xuống dòng
      }

      // In ra màn hình tổng của các phẩn tử ma trận tam giác trên
      Console.Write($"\nTổng các phần tử tam giác trên: {sum}\n");
      _ = Console.ReadKey();
    }
  }
}
