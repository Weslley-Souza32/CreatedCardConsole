using CreatedCardConsole.Interfaces;
using CreatedCardConsole.Models;

namespace CreatedCardConsole.Repositories
{
    public class CardRepository : ICardRepository
    {
        public Card GetByNumber(string number)
        {
            return null;
        }

        public int Save(Card card)
        {
            return 1;
        }
    }
}
