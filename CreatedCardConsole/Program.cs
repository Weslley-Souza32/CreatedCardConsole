using CreatedCardConsole.Models;
using CreatedCardConsole.Services;

CardService service =  new CardService();
Responsible responsible = new Responsible(0, "Weslley Junio", "09597331675");

Card myCard = CreateCard.CreatedCard(Brand.MasterCard, responsible);
myCard.Deposit(1000);
myCard.Buy(500);
myCard.Buy(300);


string result = @$"
Saldo: {myCard.Money}:
Número: {myCard.Number} ";

Console.WriteLine(result);
