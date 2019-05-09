using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b = new Buffet();
            SweetTooth ay = new SweetTooth("Aytan");
            while(!ay.IsFull)
            {
                ay.Consume(b.Serve());
            }
            ay.Consume(b.Serve());
            Console.WriteLine("===================");
            SpiceHound rj = new SpiceHound("Ranjan");
            while(!rj.IsFull)
            {
                rj.Consume(b.Serve());
            }
            rj.Consume(b.Serve());
        }
    }
}
