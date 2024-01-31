using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;
using System.Drawing;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class MovieSeedConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                  new Movie
                  {
                      Id = 1,
                      Title = "The Marvels",
                      Rating = "5.0",
                      Duration = "1h 45mins",
                      MovieDescription = "Brie Larson, Iman Vellani, and director Nia DaCosta surprised fans across the country. Carol Danvers AKA Captain Marvel has reclaimed her identity from the tyrannical Kree and taken revenge on the Supreme Intelligence. But unintended consequences see Carol shouldering the burden of a destabilized universe.",
                      Cast = "Brie Larson, Teyonah Parris, Iman Vellani",
                      Review = "okok",
                      Poster = "/posters/marvels.jpeg"
                  },
                  new Movie
                  {
                      Id = 2,
                      Title = "Barbie",
                      Rating = "3.9",
                      Duration = "1h 33mins",
                      MovieDescription = "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.",
                      Cast = "Margot Robbie, Ryan Gosling",
                      Review = "meh",
                      Poster = "/posters/barbie.jpg"
                  },
                  new Movie
                  {
                      Id = 3,
                      Title = "Wonka",
                      Rating = "2.0",
                      Duration = "1h 30mins",
                      MovieDescription = "With dreams of opening a shop in a city renowned for its chocolate, a young and poor Willy Wonka discovers that the industry is run by a cartel of greedy chocolatiers.",
                      Cast = "Timothee Chalemet",
                      Review = "eeee",
                      Poster = "/posters/wonka.jpg"
                  },
                   new Movie
                   {
                       Id = 4,
                       Title = "Blade",
                       Rating = "2.3",
                       Duration = "1h 13mins",
                       MovieDescription = "Blade, now a wanted man by the FBI, must join forces with the Nightstalkers to face his most challenging enemy yet: Dracula.",
                       Cast = "David S. Goyer",
                       Review = "ok",
                       Poster = "/posters/blade3.jpg"
                   },
                   new Movie
                   {
                       Id = 5,
                       Title = "Godzilla",
                       Rating = "2.3",
                       Duration = "1h 33mins",
                       MovieDescription = "The epic next chapter in the cinematic Monsterverse pits two of the greatest icons in motion picture history against each other--the fearsome Godzilla and the mighty Kong--with humanity caught in the balance.",
                       Cast = "Alexander Skarsgård, Millie Bobbie Brown",
                       Review = "ok only",
                       Poster = "/posters/godzillaa.jpg"
                   },
                   new Movie
                   {
                       Id = 6,
                       Title = "Train To Busan",
                       Rating = "4.8",
                       Duration = "1h 43mins",
                       MovieDescription = "While a zombie virus breaks out in South Korea, passengers struggle to survive on the train from Seoul to Busan.",
                       Cast = "Gong Yoo, Jung Yumi, Ma Dong Seok",
                       Review = "nice",
                       Poster = "/posters/traintobusan.jpg"
                   },
                   new Movie
                   {
                       Id = 7,
                       Title = "Nemo",
                       Rating = "4.9",
                       Duration = "1h 23mins",
                       MovieDescription = "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.",
                       Cast = "Albert Brooks",
                       Review = "amazing",
                       Poster = "/posters/nemo.jpg"
                   },
                   new Movie
                   {
                       Id = 8,
                       Title = "Deadpool",
                       Rating = "3.9",
                       Duration = "1h 54mins",
                       MovieDescription = "A wisecracking mercenary gets experimented on and becomes immortal yet hideously scarred, and sets out to track down the man who ruined his looks.",
                       Cast = "Ryan Reynolds",
                       Review = "not bad",
                       Poster = "/posters/deadpool.jpg"
                   }

);
        }
    }
}