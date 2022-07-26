namespace HomeworkWebApi.Models.DbModels
{
    public class Profile
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? UserId { get; set; }
        public User ItsUser { get; set; }
    }
}
