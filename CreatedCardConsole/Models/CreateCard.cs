namespace CreatedCardConsole.Models
{
    public static class CreateCard
    {
        public static Card CreatedCard(Brand brand, Responsible responsible)
        {
            ValidResponsible.ValidResposibleCard(responsible);
            string cardNumber = GeneratorNumber.GeneratorCardNumber();

            Card cardCreated = new Card()
            {
                Number = cardNumber,
                BrandCard = brand,
                Responsible = responsible,
                Status = CardStatus.Active,
            };
            return cardCreated;
        }
    }
}
