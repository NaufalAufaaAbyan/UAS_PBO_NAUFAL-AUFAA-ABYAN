using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO_NAUFAL_AUFAA_ABYAN
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Login login = new Login(); // Bikin objek dari class Login, namanya login
            
            login.tampilForm(); // Tampilkan form login dan ambil input user
            
            if (login.apakahLoginBerhasil()) // Cek apakah username dan password benar
            {
                Console.WriteLine("Login Berhasil. Selamat Datang, " + login.username); // Tampilkan pesan sukses login
            }
            else // Kalau login gagal
            {
                Console.WriteLine("Login Gagal"); // Tampilkan pesan gagal
            }

            Console.ReadKey(); // Pause biar console gak langsung nutup
        }
    }
}
