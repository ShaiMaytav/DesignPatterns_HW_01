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
            Physics physics = Physics.Instance;
            Console.WriteLine(physics.Gravity);
            Console.WriteLine(physics.CheckCollision());
        }
    }

    public class Physics
    {

        private static Physics instance;
        private Physics() { }

        public static Physics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Physics();
                }
                return instance;
            }
        }

        public float Gravity = 9.807f;

        public bool CheckCollision()
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
