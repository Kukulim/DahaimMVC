namespace DahaimMVC.Migrations
{
    using DahaimMVC.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DahaimMVC.Models.UserDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DahaimMVC.Models.UserDbContext context)
        {
            context.User.AddOrUpdate( x => x.UserId,
                new User() { UserId = 1, Name = "Mietek", UserName = "muser", ConfirmPassword = "mpass1", UserPassword = "mpass1", Email = "mietek@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "123123123" },
                new User() { UserId = 2, Name = "Czesiek", UserName = "Czesiek", ConfirmPassword = "Czesiek1", UserPassword = "Czesiek1", Email = "Czesiek@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "123123123" },
                new User() { UserId = 3, Name = "Heniek", UserName = "Heniek", ConfirmPassword = "Heniek1", UserPassword = "Heniek1", Email = "Heniek@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "123123123" },
                new User() { UserId = 4, Name = "Maniek", UserName = "Maniek", ConfirmPassword = "Maniek1", UserPassword = "Maniek1", Email = "Maniek@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "666777666" },
                new User() { UserId = 5, Name = "Lucek", UserName = "Lucek", ConfirmPassword = "Lucek1", UserPassword = "Lucek1", Email = "Lucek@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "666777666" },
                new User() { UserId = 6, Name = "Stefan", UserName = "Stefan", ConfirmPassword = "Stefan1", UserPassword = "Stefan1", Email = "Stefan@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Nazwiskowy", PhoneNumber = "666777666" },
                new User() { UserId = 7, Name = "Mariola", UserName = "Mariola", ConfirmPassword = "Mariola1", UserPassword = "Mariola1", Email = "Mariola@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Polak", PhoneNumber = "666777666" },
                new User() { UserId = 8, Name = "Lucyna", UserName = "Lucyna", ConfirmPassword = "Lucyna1", UserPassword = "Lucyna1", Email = "Lucyna@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Polak", PhoneNumber = "567567567" },
                new User() { UserId = 9, Name = "Summer", UserName = "Summer", ConfirmPassword = "Summer1", UserPassword = "Summer1", Email = "Summer@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Polak", PhoneNumber = "567567567" },
                new User() { UserId = 10, Name = "Zosia", UserName = "Zosia", ConfirmPassword = "Zosia1", UserPassword = "Zosia1", Email = "Zosia@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Polak", PhoneNumber = "567567567" },
                new User() { UserId = 11, Name = "Marta", UserName = "Marta", ConfirmPassword = "Marta1", UserPassword = "Marta1", Email = "Marta@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Kowalska", PhoneNumber = "890890890" },
                new User() { UserId = 12, Name = "Genowefa", UserName = "Genowefa", ConfirmPassword = "Genowefa1", UserPassword = "Genowefa1", Email = "Genowefa@gmail.com", LanguageLvl = LanguageLvlEmun.B2, Subname = "Kowalska", PhoneNumber = "890890890" }
                );
        }
    }
}
