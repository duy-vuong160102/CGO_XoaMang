using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_XoaMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            int[] arr = new int[10];
            int n = 0;
            NhapMang(arr, ref n);
            XuatMang(arr, n);
            XoaMang(arr, n);
            XuatMang(arr, n);
            Console.ReadKey();
        }
        private static void NhapMang(int[] arr, ref int n)
        {
            Console.Write("Nhap n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Nhap cac gia tri: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        private static void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }
        private static void XoaMang(int[] arr, int n)
        {
            int i, pos;
            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                arr[i] = arr[i + 1];
                i++;
            }
            n--;
        }

    }
}
