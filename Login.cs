using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO_NAUFAL_AUFAA_ABYAN
{
    internal class Login // Ini class Login, isinya data dan fungsi buat login user
    {
        public string judulForm = "=====Login User====="; // Teks judul yang bakal ditampilin pas login
        public string username; // Buat nyimpen input username dari user
        public string password; // Buat nyimpen input password dari user

        // method ini untuk menampilkan input login console
        public void tampilForm() // Method buat nampilin form login dan ambil input dari user
        {
            Console.SetCursorPosition((Console.WindowWidth - this.judulForm.Length) / 2, Console.CursorTop);  // Biar teks judul login muncul di tengah layar
            Console.WriteLine(this.judulForm); // Nampilin judul form login
            Console.WriteLine(); // Bikin baris kosong biar gak dempet
            Console.Write("UserName : "); this.username = Console.ReadLine(); // Nampilin teks buat input username, lalu baca inputannya
            Console.Write("Password : "); this.password = Console.ReadLine(); // Nampilin teks buat input password, lalu baca inputannya
        }

        /*
         * method ini untuk mengecek login berhasil atau tidak
         * @return bool
         */
        public bool apakahLoginBerhasil() // Method buat ngecek apakah login-nya bener atau nggak
        {
            if (this.username == "admin" && this.password == "rahasia") // Cek apakah user dan pass sesuai
            {
                return true; // Login berhasil
            }
            return false; // Login gagal
        }
    }
}
