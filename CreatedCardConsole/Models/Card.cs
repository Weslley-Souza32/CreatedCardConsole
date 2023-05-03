namespace CreatedCardConsole.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Money { get; private set; }
        public CardStatus Status { get; set; }
        public Responsible Responsible { get; set; }
        public Brand BrandCard { get; set; }



        public void Deposit(decimal amount)
        {
            this.Money += amount;
        }

        public void Buy(decimal amount)
        {
            this.Money -= amount;
        }

       
    }
}
