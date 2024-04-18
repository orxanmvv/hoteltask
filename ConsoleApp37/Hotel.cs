using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Hotel
    {

        public string Name { get; set; }
        private List<Room> Rooms { get; set; } = new List<Room>();

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("bele otaq yoxdur");
            }

             Rooms.Find(r => r.Id == roomId);
            Room room = Rooms.Find(r => r.Id == roomId);



        }

    }
}

