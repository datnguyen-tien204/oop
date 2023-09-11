using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Matrix
    {
        private int[,] matrix; // Ma trận
        private int rows; // Số hàng
        private int cols; // Số cột

        // Hàm tạo ma trận
        public Matrix(int sh, int sc)
        {
            rows = sh;
            cols = sc;
            matrix = new int[rows, cols];
        }

        // Phương thức in ma trận ra màn hình
        public void Show()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Phương thức nhập ma trận từ bàn phím
        public void Nhap()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhap gia tri cho phan tu [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Phương thức cộng hai ma trận
        public Matrix Cong(Matrix matrix2)
        {
            if (rows != matrix2.rows || cols != matrix2.cols)
            {
                Console.WriteLine("Không thể cộng hai ma trận có kích thước khác nhau.");

            }

            Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.matrix[i, j] = matrix[i, j] + matrix2.matrix[i, j];
                }
            }
            return result;
        }

        // Phương thức thực hiện phép hiệu hai ma trận
        public Matrix Hieu(Matrix matrix2)
        {
            if (rows != matrix2.rows || cols != matrix2.cols)
            {
                Console.WriteLine("Khong the tru 2 ma tran cho nhau");
            }

            Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.matrix[i, j] = matrix[i, j] - matrix2.matrix[i, j];
                }
            }
            return result;
        }

        // Phương thức đổi dấu các phần tử của ma trận
        public void DoiDau()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = -matrix[i, j];
                }
            }

        }

        // Phương thức chuyển vị một ma trận
        public void ChuyenVi()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = matrix[j, i];
                }
            }
        }
        public Matrix Nhan(Matrix matrix2)
        {
            if (cols != matrix2.rows || rows != matrix2.cols)
            {
                Console.WriteLine("Khong the nhan 2 ma tran do su khac sau ve so hang va so cot trong 2 ma tran");
            }
            Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix2.cols; j++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        result.matrix[i, j] += matrix[j, x] * matrix2.matrix[x, j];
                    }
                }
            }
            return result;
        }
        public Boolean TuongThich(Matrix matrix2)
        {
            if (cols != matrix2.rows || rows != matrix2.cols)
            {
                return false;
            }
            else
            {
                return true;
            } 
                
        }
        public Boolean MaTranVuong()
        {
            if (cols == rows)
            {
                return true;
            }
            else
            { return false; }
        }
    }
        
}
