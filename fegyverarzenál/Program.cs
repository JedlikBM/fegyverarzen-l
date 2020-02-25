using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenál
{
    class Program
    {
        enum fegyverek { apaökle, uzi, m4, gránát, lánszóró, atombomba, fing }

        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.atombomba;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.fing);
            foreach (fegyverek elem in fegyvertár)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
