using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300142
{
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState=State.Terkunci;
            Console.WriteLine("pintu terkunci");
        }

        public void KunciPintu()
        {
            if (currentState==State.Terbuka){ currentState=State.Terkunci; Console.WriteLine("pintu terkunci"); }
            else { Console.WriteLine("pintu sudah terkunci"); }
        }

        public void BukaPintu()
        {
            if (currentState==State.Terkunci){ currentState=State.Terbuka; Console.WriteLine("pintu tidak terkunci"); }
            else{ Console.WriteLine("pintu sudah terbuka"); }
        }
    }
}
