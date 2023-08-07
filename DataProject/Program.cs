using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            DBconnection dBconnection = new DBconnection();
            dBconnection.query();

            Console.ReadKey();
        }
    }
}
