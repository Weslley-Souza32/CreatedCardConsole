using CreatedCardConsole.Interfaces;
using CreatedCardConsole.Models;

namespace CreatedCardConsole.Services
{
    public class CardService
    {
        private ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public CardService()
        {
        }


        public void Save(Card card)
        {
            var cardExistent = _cardRepository.GetByNumber(card.Number);

            if (cardExistent != null)
            {
                throw new ArgumentException("Já existe um cartão com este número");
            }

            var idSaved = _cardRepository.Save(card);
            card.Id = idSaved;
        }
    }
}
