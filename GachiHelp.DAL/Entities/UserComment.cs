namespace GachiHelp.DAL.Entities
{
    public class UserComment : IEntity
    {
        public int Id { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string ForumName { get; set; }

        public string Text { get; set; }

        public User Author { get; set; }
    }
}
