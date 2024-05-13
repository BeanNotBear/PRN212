namespace Multicast_Delegate
{

    public delegate void Delegate1(string msg);
    internal class Program
    {

        static void ShowerLower(string msg)
        {
            Console.WriteLine(msg.ToLower());
        }

        static void ShowerUpper(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }


        static void Main(string[] args)
        {
            // Multicast-delegate: 1 delegate
            // point to many method
            // point to a method many time
            // using += to point
            // using -= to remove a method

            Delegate1 de1 = ShowerUpper;
            de1 += ShowerLower;
            de1("Hello wrold!");

            Console.WriteLine("---------------------------------");
            de1 -= ShowerLower;
            Console.WriteLine("After remove ShowLower()");
            de1("Hello wrold!");

            de1 -= ShowerUpper;

            Console.WriteLine(de1);
        }
    }
}
