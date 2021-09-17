using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_quete3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            Byte[] encodedbytes = Encoding.ASCII.GetBytes(s);
        }
    }
}
