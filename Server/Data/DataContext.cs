using BroadmountainLive.Shared;
using Microsoft.EntityFrameworkCore;

namespace BroadmountainLive.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NavImage>().HasData(
            new NavImage
            {
                Id = 1,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/About me.png",
                IsExt = false,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "/aboutme",
                Delay = 0,
                Text = ""
            },
            new NavImage
            {
                Id = 2,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/Cv.png",
                IsExt = false,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "/cv",
                Delay = 0,
                Text = ""
            },
            new NavImage
            {
                Id = 3,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/Projects.png",
                IsExt = false,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "/project",
                Delay = 0,
                Text = ""
            },
            new NavImage
            {
                Id = 4,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/Skills.png",
                IsExt = false,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "/skillsandcerts",
                Delay = 0,
                Text = ""
            },
            new NavImage
            {
                Id = 5,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/GitHub.png",
                IsExt = true,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "https://github.com/MageeMoose",
                Delay = 0,
                Text = ""
            },
            new NavImage
            {
                Id = 6,
                ImgUrl = "BroadmountainLive/Client/wwwroot/images/Linkedin.png",
                IsExt = true,
                IsSign = false,
                IsTopNav = false,
                AltText = "",
                PathName = "https://www.linkedin.com/in/magnus-bredberg-b3684121/",
                Delay = 0,
                Text = ""
            }
        );
    }

    public DbSet<NavImage> NavImages { get; set; }
}