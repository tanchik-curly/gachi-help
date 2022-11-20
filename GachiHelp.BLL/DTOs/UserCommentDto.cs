namespace GachiHelp.BLL.DTOs
{
    public class UserCommentDto
    {
        public int Id { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string ForumName { get; set; }

        public string Text { get; set; }

        public UserDto Author { get; set; }
    }
}
