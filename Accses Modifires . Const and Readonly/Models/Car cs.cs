

namespace Accses_Modifires_._Const_and_Readonly.Models
{
    internal class Car_cs
    {
        private string name;
        public string color;
        protected int speed = 900;

        private Car_cs()
        {
            //Console.WriteLine(" Reshad bey bu da sizin ucun private costructor ");

        }
        public Car_cs(int a) : this()
        {

        }

    }
}
