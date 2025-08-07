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
            
            login.tampilForm(); // Panggil method tampilForm buat nampilin form dan ambil input dari user
            
            if(login.apakahLoginBerhasil()) // Bikin objek dari class Login, namanya login
            {
                Console.WriteLine("Login Berhasil. Selamat Datang, " + login.username); // Bikin objek dari class Login, namanya login
            }
            else // Kalo gagal
            {
                Console.WriteLine("Login Gagal"); // Tampilkan pesan gagal
            }
            Console.ReadKey(); // Biar console nggak langsung nutup, tunggu user pencet tombol
        }
    }
}
