using CreatedCardConsole.Models;
using CreatedCardConsole.Services;

namespace CreatedCardConsole.Test.CardTest
{
    public class CreateCardTest
    {
        [Fact(DisplayName ="Testando cartão com número.")]
        public void DeveCriarCartaoComNumero()
        {
            //Arrange
            CardService cardService = new CardService();
            Responsible responsible = new Responsible(1, "Weslley Junio", "000.000.00-00");

            //Act
            var card = CreateCard.CreatedCard(Brand.Elo, responsible);

            //Assert xunit
            Assert.NotNull(card.Number);
            Assert.NotEqual("", card.Number);
        }

        [Fact(DisplayName = "Testando cartão com pessoa sem doc")]
        public void DeveRetornarErroPessoaSemDocumento()
        {
            CardService cardService = new CardService();
            Responsible responsible = new Responsible(1, "Weslley Junio", "");

            Func<Card> card = () => CreateCard.CreatedCard(Brand.Visa, responsible);

            var exception = Assert.Throws<ArgumentException>(card);
            Assert.Contains("campo obrigatório", exception.Message.ToLower());
        }


        [Fact(DisplayName = "Testando Depósito")]
        public void TestandoDeposito()
        {
            CardService cardService = new CardService();
            Responsible responsible = new Responsible(1, "Weslley Junio", "000.000.000-00");

            var card = CreateCard.CreatedCard(Brand.Elo, responsible);
            card.Deposit(1000);

            Assert.Equal(1000, card.Money);
        }

        [Fact(DisplayName ="Testando Compra")]
        public void TestandoCompra()
        {
            CardService cardService = new CardService();
            Responsible responsible = new Responsible(1, "Weslley Junio", "000.000.000-00"); ;

            var card = CreateCard.CreatedCard(Brand.MasterCard, responsible);
            card.Deposit(1000);
            card.Buy(800);

            Assert.Equal(200, card.Money);
        }

        [Theory(DisplayName ="Testando documentos válidos")]
        [InlineData("1")]
        [InlineData("123")]
        [InlineData("123456")]
        public void TestandoDocumentoValidos(string document)
        {
            try
            {
                CardService cardService = new CardService();
                Responsible responsible = new Responsible(1, "Weslley Junio", document); ;

                var card = CreateCard.CreatedCard(Brand.MasterCard, responsible);
            }
            catch (Exception error)
            {

                Assert.Fail(error.Message);
            }
            
        }

        [Theory(DisplayName = "Testando Documentos inválidos")]
        [InlineData("")]
        [InlineData(null)]
        public void TestandoDocumentosNaoValidos(string document)
        {
            try
            {
                
                CardService cardService = new CardService();
                Responsible responsible = new Responsible(1, "Weslley Junio", document); ;

                
                ValidResponsible.ValidResposibleCard(responsible);
                Assert.Fail("Não esperado");

            }
            catch (Exception error)
            {
                Assert.Contains("Campo obrigatório", error.Message);
            }
        }
    }
}
