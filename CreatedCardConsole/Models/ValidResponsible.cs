namespace CreatedCardConsole.Models
{
    public static class ValidResponsible
    {
        public static void ValidResposibleCard(Responsible responsible) 
        {
            if (responsible == null)
            {
                throw new ArgumentException("Responsável é obrigatório!");
            }
            if (string.IsNullOrEmpty(responsible.Name))
            {
                throw new ArgumentException("Campo obrigatório: Nome do responsável");
            }
            if (string.IsNullOrEmpty(responsible.Document))
            {
                throw new ArgumentException("Campo obrigatório:  Documento do responsável");
            }


        }

    }
}
