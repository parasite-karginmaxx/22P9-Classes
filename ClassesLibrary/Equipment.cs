namespace ClassesLibrary;
//  https://docs.google.com/document/d/1ynMOoROmPiCWqPt78fnwQoIJKsoAIgdxhzp1VSjatsE/edit
    public class Equipment
    {
        public string name;
        public decimal cost;
        public DateTime balance;

        public Equipment(string name, decimal cost, DateTime balance = DateTime.Today())
        {
            this.name = name;
            this.cost = cost;
            this.balance = balance;
        }
    }
