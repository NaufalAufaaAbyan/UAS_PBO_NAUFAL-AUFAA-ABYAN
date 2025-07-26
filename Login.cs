using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO_NAUFAL_AUFAA_ABYAN
{
    internal class Login
    {
        public string judulForm = "=====Login User=====";
        public string username;
        public string password;

        public void tampilForm()
        {
            Console.SetCursorPosition((Console.WindowHeight - this.judulForm.Length) / 2, Console.CursorTop);
            Console.WriteLine(this.judulForm);
            Console.WriteLine();
            Console.Write("UserName : "); this.username = Console.ReadLine();
            Console.Write("Password : "); this.password = Console.ReadLine();
        }

        public bool apakahLoginBerhasil()
        {
            if (this.username=="admin" && this.password=="rahasia")
            {
                return true;
            }
            return false;
        }
    }
}
