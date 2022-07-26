namespace HomeworkWebApi.Models.DbModels
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ProfileId { get; set; }
        public Profile ItsProfile { get; set; }
        public DateTime Sent { get; set; }
    }
}
