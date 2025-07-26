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
            Login login = new Login();
            login.tampilForm();
            if(login.apakahLoginBerhasil())
            {
                Console.WriteLine("Login Berhasil. Selamat Datang, " + login.username);
            }
            else
            {
                Console.WriteLine("Login Gagal");
            }
            Console.ReadKey();
        }
    }
}
