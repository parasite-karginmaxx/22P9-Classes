namespace ClassesLibrary
{
    public class Equipment
    {
        public string name;
        public decimal cost;
        public DateTime balance;

        public Equipment(string name, DateTime balance = DateTime.Today)
        {
            this.name = name;
            this.cost = cost;
            this.balance = balance;
        }
    }
}