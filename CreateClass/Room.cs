namespace CreateClass
{
    public class Room
    {
        private int roomNumber;
        
        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        
        public int RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }
    }
}