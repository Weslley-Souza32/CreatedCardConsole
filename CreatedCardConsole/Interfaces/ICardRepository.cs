using CreatedCardConsole.Models;

namespace CreatedCardConsole.Interfaces
{
    public interface ICardRepository
    {
        Card GetByNumber(string number);
        int Save(Card card);
    }
}
