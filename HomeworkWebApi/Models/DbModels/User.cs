namespace HomeworkWebApi.Models.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public Profile ItsProfile { get; set; }
    }
}
