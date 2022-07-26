using Microsoft.EntityFrameworkCore;
using HomeworkWebApi.Models.DbModels;

namespace HomeworkWebApi.Models.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User{Id = 1, Name ="Alex", Age=30},
                new User{Id = 2, Name ="John", Age=20},
                new User{Id = 3, Name ="Alice", Age=40},
                new User{Id = 4, Name ="Bob", Age=25},
                new User{Id = 5, Name ="Kate", Age=17},
            });

            modelBuilder.Entity<Profile>().HasData(new Profile[]
            {
                new Profile{Id = 1, Login="Alexis", Password="242353dsddf", UserId=1},
                new Profile{Id = 2, Login="Naruto", Password="ddgff44499kk", UserId=2},
                new Profile{Id = 3, Login="Level", Password="safggrg", UserId=3},
                new Profile{Id = 4, Login="Carito", Password="456uhhgf", UserId=4},
                new Profile{Id = 5, Login="Claster", Password="zCc87SSS", UserId=5},
            });
            modelBuilder.Entity<Message>().HasData(new Message[] {
            new Message{Id=1, ProfileId=1, Text="Hello!", Sent=new DateTime(2022, 07, 06, 12,00,00)},
            new Message{Id=2, ProfileId=2, Text="Hi!", Sent=new DateTime(2022, 07, 06, 12,10,00)},
            new Message{Id=3, ProfileId=3, Text="How r u?", Sent=new DateTime(2022, 07, 06, 12,20,00)},
            new Message{Id=4, ProfileId=4, Text="Everything is good!", Sent=new DateTime(2022, 07, 06, 12,30,00)},
            new Message{Id=5, ProfileId=5, Text="Lets drink vodka!", Sent=new DateTime(2022, 07, 06, 12,40,00)},
            new Message{Id=6, ProfileId=1, Text="Its a good idea!", Sent=new DateTime(2022, 07, 06, 12,50,00)},
            new Message{Id=7, ProfileId=2, Text="See you in the park tonight!", Sent=new DateTime(2022, 07, 06, 13,00,00)},
            new Message{Id=8, ProfileId=3, Text="See you!", Sent=new DateTime(2022, 07, 06, 13,10,00)},
            });
        }
    }
}
