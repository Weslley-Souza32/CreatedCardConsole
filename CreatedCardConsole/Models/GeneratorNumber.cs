namespace CreatedCardConsole.Models
{
    public static class GeneratorNumber
    {
        public static string GeneratorCardNumber()
        {
            Random random = new Random();
            int number1 = random.Next(9999);
            int number2 = random.Next(9999);
            int number3 = random.Next(9999);
            int number4 = random.Next(9999);
            return $"{number1} {number2} {number3} {number4}";
        }
    }
}
