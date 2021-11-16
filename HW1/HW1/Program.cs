using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherBoard mom = MotherBoard.Instance;
            Console.WriteLine(mom.firmWare);
            Console.WriteLine(mom.year);
            mom.SelfDestruct();
        }
    }

    public class MotherBoard
    {

        private static MotherBoard instance;
        private MotherBoard() { }

        public static MotherBoard Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MotherBoard();
                }
                return instance;
            }
        }

        public int year = 2014;
        public string firmWare = "GIGABYTE";

        public void SelfDestruct()
        {
            Console.WriteLine("Killing Myself Right Now...");
        }
    }
}
