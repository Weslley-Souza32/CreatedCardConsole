namespace CreatedCardConsole.Models
{
    public class Responsible
    {
        public Responsible(int id, string name, string document)
        {
            Id = id;
            Name = name;
            Document = document;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; private set; }
    }
}
