namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel =new Hotel("Ayli Gece");
            Room room1=new Room("orxan",15,15);
            Room room2 = new Room("Kenann", 15, 15);
            Room room3 = new Room("Resul", 15, 15);
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);
           
            Console.WriteLine(room1.ShowInfo());
            hotel.MakeReservation(2);
        }
    }
}