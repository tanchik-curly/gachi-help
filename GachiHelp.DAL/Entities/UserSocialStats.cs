namespace GachiHelp.DAL.Entities
{
    public class UserSocialStats : IEntity
    {
        public int Id { get; set; }

        public int VotesCount { get; set; }

        public int ClosedDiscussionsCount { get; set; }

        public int AnswearsCount { get; set; }

        public int Carma { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
