using ustaTickets.Models;
using static System.Net.WebRequestMethods;

namespace ustaTickets.Data
{
    public class AppInicializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Paramount Pictures",
                            Logo = "http://localhost/img/cinemas/paramount.png",
                            Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the main namesake division of Paramount Global (formerly ViacomCBS)."
                        },
                        new Cinema()
                        {
                            Name = "20th Century Studios",
                            Logo = "http://localhost/img/cinemas/20century.png",
                            Description = "20th Century Studios, Inc. (formerly known 20th Century Fox Film Corporation) is an American film production studio headquartered at the Fox Studio Lot in the Century City area of Los Angeles."
                        },
                        new Cinema()
                        {
                            Name = "Universal Pictures",
                            Logo = "http://localhost/img/cinemas/universalpictures.png",
                            Description = "Universal Pictures is an American film production and distribution company owned by Comcast through the NBCUniversal Film and Entertainment division of NBCUniversal."
                        },
                        new Cinema()
                        {
                            Name = "Lionsgate",
                            Logo = "http://localhost/img/cinemas/lionsgate.jpg",
                            Description = "Lionsgate Films is an American film production and film distribution studio, headquartered in Santa Monica and founded in Canada, and is the flagship[vague] division of Lionsgate Entertainment. It is the largest and most successful mini-major film studio in North America."
                        },
                        new Cinema()
                        {
                            Name = "Summit Entetaiment",
                            Logo = "http://localhost/img/cinemas/summitentertaiment.png",
                            Description = "Summit Entertainment is an American film production and distribution company. It is a label of Lionsgate Films, owned by Lionsgate Entertainment and is headquartered in Santa Monica, California."

                        },
                        new Cinema()
                        {
                            Name = "Warner Bros. Pictures",
                            Logo = "http://localhost/img/cinemas/warnerbros.png",
                            Description = "Warner Bros. Pictures is an American film production and distribution company of the Warner Bros. Pictures Group division of Warner Bros. Entertainment (both ultimately owned by Warner Bros. Discovery). The studio is the flagship producer of live-action feature films within the Warner Bros."
                        }
                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        //Avatar Actors
                        new Actor()
                        {
                            FullName = "Sam Worthington",
                            ProfilePictureURL = "http://localhost/img/actors/samworthington.jpg",
                            Bio = "Samuel Henry John Worthington (born 2 August 1976) is an Australian actor. He is best known for playing Jake Sully in Avatar, Marcus Wright in Terminator Salvation, and Perseus in Clash of the Titans and its sequel Wrath of the Titans. He later took more dramatic roles, appearing in The Debt (2010), Everest (2015), Hacksaw Ridge (2016), The Shack (2017)."
                        },
                        new Actor()
                        {
                            FullName = "Zoe Saldaña",
                            ProfilePictureURL = "http://localhost/img/actors/zoesaldana.jpg",
                            Bio = "Zoe Yadira Saldaña-Perego (née Saldaña Nazario; born June 19, 1978) is an American actress. After performing with the theater group Faces she appeared in two 1999 episodes of Law & Order. Her film career began a year later with Center Stage (2000) in which she portrayed a ballet dancer."
                        },
                        new Actor()
                        {
                            FullName = "Stephen Lang",
                            ProfilePictureURL = "http://localhost/img/actors/stephenlang.jpg",
                            Bio = "Stephen Lang (born July 11, 1952) is an American actor. He is known for roles in films including Manhunter (1986), Gettysburg, Tombstone (both 1993), Gods and Generals (2003), Public Enemies (2009), Conan the Barbarian (2011), The Girl on the Train (2013) and Don't Breathe (2016)."
                        },
                        //Divergent Actors
                        new Actor()
                        {
                            FullName = "Shailene Woodley",
                            ProfilePictureURL = "http://localhost/img/actors/shailenewoodley.jpg",
                            Bio = "Shailene Diann Woodley (born November 15, 1991) is an American actress. Born in San Bernardino, California, Woodley was raised in Simi Valley, and started modeling at the age of four and began acting professionally in minor television roles. She first gained prominence for her starring role as Amy Juergens in the ABC Family drama series The Secret Life of the American Teenager (2008–2013). "
                        },
                        new Actor()
                        {
                            FullName = "Theo James",
                            ProfilePictureURL = "http://localhost/img/actors/theojames.jpg",
                            Bio = "Theodore Peter James Kinnaird Taptiklis (born 16 December 1984) is an English actor. He is known for portraying Tobias Eaton in The Divergent Series film trilogy. James starred in the horror films Underworld: Awakening (2012) and Underworld: Blood Wars (2016), the action film How It Ends (2018), and the science fiction film Archive (2020)."
                        },
                        new Actor()
                        {
                            FullName = "Ashley Judd",
                            ProfilePictureURL = "http://localhost/img/actors/ashleyjudd.jpg",
                            Bio = "Ashley Judd (born Ashley Tyler Ciminella; April 19, 1968) is an American actress. She grew up in a family of performing artists: she is the daughter of the late country music singer Naomi Judd and the half-sister of country music singer Wynonna Judd."
                        },
                        //Exmachina Actors
                        new Actor()
                        {
                            FullName = "Domhnall Gleeson",
                            ProfilePictureURL = "http://localhost/img/actors/domhnallgleeson.jpg",
                            Bio = "Domhnall Gleeson (born 12 May 1983) is an Irish actor and screenwriter. He is the son of actor Brendan Gleeson, with whom he has appeared in a number of films and theatre projects. He received a Bachelor of Arts in Media Arts from Dublin Institute of Technology."
                        },
                        new Actor()
                        {
                            FullName = "Oscar Isaac",
                            ProfilePictureURL = "http://localhost/img/actors/oscarisaac.jpg",
                            Bio = "Óscar Isaac Hernández Estrada (born March 9, 1979) is a Guatemalan-born American actor. Known for his versatility, he has been credited with breaking stereotypes about Latino characters in Hollywood. He was named the best actor of his generation by Vanity Fair in 2017 and one of the 25 greatest actors of the 21st century by The New York Times in 2020."
                        },
                        new Actor()
                        {
                            FullName = "Alicia Vikander",
                            ProfilePictureURL = "http://localhost/img/actors/aliciavikander.jpg",
                            Bio = "Alicia Amanda Vikander (born 3 October 1988) is a Swedish actress. She is the recipient of various accolades, including an Academy Award, in addition to nominations for two Golden Globe Awards and three British Academy Film Awards."
                        },
                        //F9 Actors
                        new Actor()
                        {
                            FullName = "Vin Diesel",
                            ProfilePictureURL = "http://localhost/img/actors/vindiesel.jpg",
                            Bio = "Mark Sinclair (born July 18, 1967), known professionally as Vin Diesel, is an American actor and producer. One of the world's highest-grossing actors, he is best known for playing Dominic Toretto in the Fast & Furious franchise."
                        },
                        new Actor()
                        {
                            FullName = "Tyrese Gibson",
                            ProfilePictureURL = "http://localhost/img/actors/tyresegibson.jpg",
                            Bio = "Tyrese Darnell Gibson (born December 30, 1978) is an American R&B singer and actor. He released his self-titled debut album in 1998, which featured the single Sweet Lady, peaking at number twelve on the U.S. Billboard Hot 100."
                        },
                        new Actor()
                        {
                            FullName = "Michelle Rodriguez",
                            ProfilePictureURL = "http://localhost/img/actors/michellerodriguez.jpg",
                            Bio = "Mayte Michelle Rodriguez (born July 12, 1978) is an American actress and screenwriter. Rodriguez began her career in 2000, playing a troubled boxer in the independent sports drama film Girlfight (2000), where she won the Independent Spirit Award and Gotham Award for Best Debut Performance."
                        },
                        //Hunger Games Actors
                        new Actor()
                        {
                            FullName = "Jennifer Lawrence",
                            ProfilePictureURL = "http://localhost/img/actors/jenniferlawrence.jpg",
                            Bio = "Jennifer Shrader Lawrence (born August 15, 1990) is an American actress. The world's highest-paid actress in 2015 and 2016, her films have grossed over $6 billion worldwide to date. She appeared in Time's 100 most influential people in the world list in 2013 and the Forbes Celebrity 100 list from 2013 to 2016."
                        },
                        new Actor()
                        {
                            FullName = "Josh Hutcherson",
                            ProfilePictureURL = "http://localhost/img/actors/joshhutcherson.jpg",
                            Bio = "Joshua Ryan Hutcherson (born October 12, 1992) is an American actor and producer. Hutcherson began acting in the early 2000s and appeared in several commercials and minor film and television roles before landing his first major role in 2002 in the pilot episode of House Blend."
                        },
                        new Actor()
                        {
                            FullName = "Liam Hemsworth",
                            ProfilePictureURL = "http://localhost/img/actors/liamhemsworth.jpg",
                            Bio = "Liam Hemsworth (born 13 January 1990) is an Australian actor. He played the roles of Josh Taylor in the soap opera Neighbours and Marcus in the children's television series The Elephant Princess."
                        },
                        //Inception Actors
                        new Actor()
                        {
                            FullName = "Leonardo DiCaprio",
                            ProfilePictureURL = "http://localhost/img/actors/leonardodicaprio.jpg",
                            Bio = "Leonardo Wilhelm DiCaprio (born November 11, 1974) is an American actor and film producer. Known for his work as a leading man in biopics and period films, he is the recipient of numerous accolades, including an Academy Award, a British Academy Film Award, and three Golden Globe Awards."
                        },
                        new Actor()
                        {
                            FullName = "Ken Watanabe",
                            ProfilePictureURL = "http://localhost/img/actors/kenwatanabe.jpg",
                            Bio = "Ken Watanabe (born October 21, 1959) is a Japanese actor. To English-speaking audiences, he is known for playing tragic hero characters, such as General Tadamichi Kuribayashi in Letters from Iwo Jima and Lord Katsumoto Moritsugu in The Last Samurai, for which he was nominated for the Academy Award for Best Supporting Actor."
                        },
                        new Actor()
                        {
                            FullName = "Joseph Gordon-Levitt",
                            ProfilePictureURL = "http://localhost/img/actors/josephgordon.jpeg",
                            Bio = "Joseph Leonard Gordon-Levitt (born February 17, 1981) is an American actor and filmmaker. He has received various accolades, including nominations for the Golden Globe Award for Best Actor – Motion Picture Musical or Comedy for his leading performances in 500 Days of Summer (2009) and 50/50 (2011)."
                        },
                        //MazeRunner Actors
                        new Actor()
                        {
                            FullName = "Dylan O'Brien",
                            ProfilePictureURL = "http://localhost/img/actors/dylanobrien.jpg",
                            Bio = "Dylan Rhodes O'Brien (born August 26, 1991) is an American actor. His first major role was Stiles Stilinski on the MTV supernatural drama Teen Wolf (2011–2017), where he was a series regular during all six seasons. He achieved further prominence for his lead role of Thomas in the Maze Runner science fiction film trilogy (2014–2018), which led to more film appearances."
                        },
                        new Actor()
                        {
                            FullName = "Kaya Scodelario",
                            ProfilePictureURL = "http://localhost/img/actors/kayascodelario.jpg",
                            Bio = "Kaya Rose Scodelario-Davis (born 13 March 1992) is an English actress best known for her roles as Effy Stonem on the E4 teen drama Skins (2007–2010, 2013), and Teresa in the Maze Runner film series (2014–2018)."
                        },
                        new Actor()
                        {
                            FullName = "Thomas Brodie-Sangster",
                            ProfilePictureURL = "http://localhost/img/actors/thomasbrodie.jpg",
                            Bio = "Thomas Brodie-Sangster (born 16 May 1990), also credited as Thomas Sangster, is an English actor. He is known for playing Sam in Love Actually (2003), Simon in Nanny McPhee (2005), Ferb in Phineas and Ferb (2007–2015), Jojen Reed in Game of Thrones (2013–2014)."
                        },
                        //RequiemForADream Actors
                        new Actor()
                        {
                            FullName = "Jared Leto",
                            ProfilePictureURL = "http://localhost/img/actors/jaredleto.jpg",
                            Bio = "Jared Joseph Leto (born December 26, 1971) is an American actor and musician. Known for his method acting in a variety of roles, he has received numerous accolades over a career spanning three decades, including an Academy Award and a Golden Globe Award."
                        },
                        new Actor()
                        {
                            FullName = "Jennifer Connelly",
                            ProfilePictureURL = "http://localhost/img/actors/jenniferconnelly.jpg",
                            Bio = "Jennifer Lynn Connelly (born December 12, 1970) is an American actress. She began her career as a child model before making her acting debut in the 1984 crime film Once Upon a Time in America. After having worked as a model for several years, she began to concentrate on acting, starring in a variety of films including the horror film Phenomena (1985), the musical fantasy film Labyrinth (1986)."
                        },
                        new Actor()
                        {
                            FullName = "Marlon Wayans",
                            ProfilePictureURL = "http://localhost/img/actors/marlonwayans.jpg",
                            Bio = "Marlon Lamont Wayans (born July 23, 1972) is an American actor, comedian, writer, and producer. Wayans began his career portraying a pedestrian in I'm Gonna Git You Sucka (1988). He went on to regularly collaborate with his brother Shawn Wayans on The WB sitcom The Wayans Bros."
                        },
                        //TopGun Actors
                        new Actor()
                        {
                            FullName = "Tom Cruise",
                            ProfilePictureURL = "http://localhost/img/actors/tomcruise.jpg",
                            Bio = "Thomas Cruise Mapother IV (born July 3, 1962), known professionally as Tom Cruise, is an American actor and producer. One of the world's highest-paid actors, he has received various accolades, including an Honorary Palme d'Or and three Golden Globe Awards, in addition to nominations for three Academy Awards."
                        },
                        //jennifer connelly
                        new Actor()
                        {
                            FullName = "Miles Teller",
                            ProfilePictureURL = "http://localhost/img/actors/milesteller.jpg",
                            Bio = "Miles Alexander Teller (born February 20, 1987) is an American actor. He is most widely recognized for his roles as jazz drummer Andrew Neiman in Whiplash and pilot Lt. Bradley Rooster Bradshaw in Top Gun: Maverick."
                        },
                        //TheWolfOfWallStreet Actors
                        new Actor()
                        {
                            FullName = "Jonah Hill",
                            ProfilePictureURL = "http://localhost/img/actors/jonahhill.jpg",
                            Bio = "Jonah Hill Feldstein (born December 20, 1983) is an American actor, filmmaker, and comedian. He is known for his comedic roles in films including Superbad (2007), Knocked Up (2007), 21 Jump Street (2012), This Is the End (2013), and 22 Jump Street (2014)."
                        },
                        //DiCaprio
                        new Actor()
                        {
                            FullName = "Margot Robbie",
                            ProfilePictureURL = "http://localhost/img/actors/margotrobbie.jpg",
                            Bio = "Margot Elise Robbie (born 2 July 1990) is an Australian actress and producer. Known for her roles in both blockbusters and independent films, she has received several accolades, including nominations for two Academy Awards, three Golden Globe Awards, and five British Academy Film Awards."
                        }
                    });
                    context.SaveChanges();
                }
                //Diectors
                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            FullName = "James Cameron",
                            ProfilePictureURL = "http://localhost/img/directors/jamescameron.jpg",
                            Bio = "James Francis Cameron CC (born August 16, 1954) is a Canadian filmmaker. Best known for making science fiction and epic films, he first gained recognition for directing The Terminator (1984). He found further success with Aliens (1986), The Abyss (1989), Terminator 2: Judgment Day (1991), and the action comedy True Lies (1994)."
                        },
                        new Director()
                        {
                            FullName = "Neil Burger",
                            ProfilePictureURL = "http://localhost/img/directors/neilburger.jpg",
                            Bio = "Neil Norman Burger (born November 22, 1963) is an American filmmaker. He is known for the fake-documentary Interview with the Assassin (2002), the period drama The Illusionist (2006), Limitless (2011), and the sci-fi action film Divergent (2014), based on the dystopian novel of the same name by Veronica Roth."
                        },
                        new Director()
                        {
                            FullName = "Alex Garland",
                            ProfilePictureURL = "http://localhost/img/directors/alexgarland.jpg",
                            Bio = "Alexander Medawar Garland[1] (born 26 May 1970)[2] is an English writer and filmmaker. He rose to prominence as a novelist in the late 1990s with his novel The Beach, which led some critics to call Garland a key voice of Generation X."
                        },
                        new Director()
                        {
                            FullName = "Justin Lin",
                            ProfilePictureURL = "http://localhost/img/directors/justinlin.jpg",
                            Bio = "Justin Lin (born October 11, 1971) is a Taiwanese-American film director. His films have grossed US$2.3 billion worldwide as of March 2017. He is best known for his directorial work on Better Luck Tomorrow (2002), the Fast & Furious franchise from The Fast and the Furious: Tokyo Drift (2006) to Fast & Furious 6 (2013) and F9 (2021), and Star Trek Beyond (2016). "
                        },
                        new Director()
                        {
                            FullName = "Gary Ross",
                            ProfilePictureURL = "http://localhost/img/directors/garyross.jpg",
                            Bio = "Gary Ross (born November 3, 1956) is an American film director, writer, and producer. He is best known for writing and directing the fantasy comedy-drama film Pleasantville (1998), the sports drama film Seabiscuit (2003), the sci-fi action film The Hunger Games (2012), and the heist comedy film Ocean's 8 (2018). Ross has been nominated for four Academy Awards."
                        },
                        new Director()
                        {
                            FullName = "Christopher Nolan",
                            ProfilePictureURL = "http://localhost/img/directors/christophernolan.jpg",
                            Bio = "Christopher Nolan CBE (born 30 July 1970) is a British-American film director, producer, and screenwriter. His films have grossed more than US$5 billion worldwide and have garnered 11 Academy Awards from 36 nominations."
                        },
                        new Director()
                        {
                            FullName = "Wes Ball",
                            ProfilePictureURL = "http://localhost/img/directors/wesball.jpg",
                            Bio = "Wes Ball (born October 28, 1980) is an American film director, visual effects artist and graphic artist. He is best known for directing the 2014 film The Maze Runner, based on James Dashner's novel. Ball also directed the sequel, Maze Runner: The Scorch Trials, which opened in theaters on September 18, 2015, and the third film, Maze Runner: The Death Cure, which opened on January 11, 2018."
                        },
                        new Director()
                        {
                            FullName = "Darren Aronofsky",
                            ProfilePictureURL = "http://localhost/img/directors/darrenaronofsky.jpg",
                            Bio = "Darren Aronofsky (born February 12, 1969) is an American film director, producer, and screenwriter. His films are noted for their surrealistic, melodramatic, and sometimes disturbing elements, often in the form of psychological fiction."
                        },
                        new Director()
                        {
                            FullName = "Joseph Kosinski",
                            ProfilePictureURL = "http://localhost/img/directors/joekosinski.jpg",
                            Bio = "Joseph Kosinski is an American filmmaker best known for his computer graphics and computer-generated imagery (CGI) work, and for his work in action films. He made his big-screen directorial debut with the 2010 science fiction film Tron: Legacy, the sequel to the 1982 film Tron."
                        },
                        new Director()
                        {
                            FullName = "Martin Scorsese",
                            ProfilePictureURL = "http://localhost/img/directors/martinscorsese.jpg",
                            Bio = "Martin Charles Scorsese (born November 17, 1942) is an American film director, producer, screenwriter and actor. He is the recipient of many accolades, including an Academy Award, three Primetime Emmy Awards, a Grammy Award, four British Academy Film Awards, three Golden Globe Awards, and two Directors Guild of America Awards."
                        },
                    });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Avatar",
                            Description = "Avatar is a 2009 American epic science fiction film directed, written, produced, and co-edited by James Cameron and starring Sam Worthington, Zoe Saldana, Stephen Lang, Michelle Rodriguez, and Sigourney Weaver.",
                            Price = 19.99,
                            ImageURL = "http://localhost/img/movies/avatar.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 2,
                            DirectorId = 1
                        },
                        new Movie()
                        {
                            Name = "Divergent",
                            Description = "Divergent is a 2014 American dystopian science fiction action film directed by Neil Burger, based on the 2011 novel of the same name by Veronica Roth. The film is the first installment in The Divergent Series and was produced by Lucy Fisher, Pouya Shahbazian, and Douglas Wick, with a screenplay by Evan Daugherty and Vanessa Taylor.",
                            Price = 19.99,
                            ImageURL = "http://localhost/img/movies/divergent.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 4,
                            DirectorId = 2
                        },
                        new Movie()
                        {
                            Name = "Ex Machina",
                            Description = "Ex Machina is a 2014 science fiction film written and directed by Alex Garland in his directorial debut. There are only four significant characters, played by Domhnall Gleeson, Alicia Vikander, Sonoya Mizuno, and Oscar Isaac.",
                            Price = 19.99,
                            ImageURL = "http://localhost/img/movies/exmachina.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 3,
                            DirectorId = 3
                        },
                        new Movie()
                        {
                            Name = "Furious 9",
                            Description = "F9 (also known as F9: The Fast Saga and internationally as Fast & Furious 9) is a 2021 American action film directed by Justin Lin from a screenplay by Daniel Casey and Lin. It is the sequel to The Fate of the Furious (2017), serving as the ninth main installment, and the tenth full-length film in the Fast & Furious franchise.",
                            Price = 15.99,
                            ImageURL = "http://localhost/img/movies/furious9.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.Action,
                            CinemaId = 3,
                            DirectorId = 4
                        },
                        new Movie()
                        {
                            Name = "Hunger Games",
                            Description = "The Hunger Games is a 2012 American dystopian action film directed by Gary Ross and based on Suzanne Collins' 2008 novel of the same name. It is the first installment in The Hunger Games film series and was produced by Nina Jacobson and Jon Kilik, with a screenplay by Ross, Collins, and Billy Ray.",
                            Price = 19.99,
                            ImageURL = "http://localhost/img/movies/hungergames.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 4,
                            DirectorId = 5
                        },
                        new Movie()
                        {
                            Name = "Inception",
                            Description = "Inception is a 2010 science fiction action film written and directed by Christopher Nolan, who also produced the film with Emma Thomas, his wife. The film stars Leonardo DiCaprio as a professional thief who steals information by infiltrating the subconscious of his targets. He is offered a chance to have his criminal history erased as payment for the implantation of another person's idea into a target's subconscious.",
                            Price = 9.99,
                            ImageURL = "http://localhost/img/movies/inception.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 6,
                            DirectorId = 6
                        },
                        new Movie()
                        {
                            Name = "Maze Runner: The Death Cure",
                            Description = "Maze Runner: The Death Cure is a 2018 American dystopian science fiction film directed by Wes Ball and written by T.S. Nowlin, based on the 2011 novel The Death Cure written by James Dashner. It is the sequel to the 2015 film Maze Runner: The Scorch Trials and the third and final installment in the Maze Runner film series.",
                            Price = 19.99,
                            ImageURL = "http://localhost/img/movies/mazerunnerdeathcure.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.ScienceFiction,
                            CinemaId = 2,
                            DirectorId = 7
                        },
                        new Movie()
                        {
                            Name = "Requiem For a Dream",
                            Description = "Requiem for a Dream is a 2000 American psychological drama film directed by Darren Aronofsky and starring Ellen Burstyn, Jared Leto, Jennifer Connelly, Christopher McDonald and Marlon Wayans. It is based on the 1978 novel of the same name by Hubert Selby Jr., with whom Aronofsky wrote the screenplay. The film depicts four characters affected by drug addiction and how it alters their physical and emotional states.",
                            Price = 3.99,
                            ImageURL = "http://localhost/img/movies/requiemforadream.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.Psychological,
                            CinemaId = 5,
                            DirectorId = 8
                        },
                        new Movie()
                        {
                            Name = "Top Gun: Maverick",
                            Description = "Top Gun: Maverick is a 2022 American action drama film directed by Joseph Kosinski. It is the sequel to the 1986 film Top Gun and the second installment in the Top Gun film series. Written by Ehren Kruger, Eric Warren Singer, and Christopher McQuarrie, the film is based on a story by Peter Craig and Justin Marks.",
                            Price = 29.99,
                            ImageURL = "http://localhost/img/movies/topgunmaverick.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.Action,
                            CinemaId = 1,
                            DirectorId = 9
                        },
                        new Movie()
                        {
                            Name = "The Wolf of Wall Street",
                            Description = "The Wolf of Wall Street is a 2013 American biographical black comedy crime film directed by Martin Scorsese and written by Terence Winter, based on the 2007 memoir of the same name by Jordan Belfort. It recounts Belfort's perspective on his career as a stockbroker in New York City and how his firm, Stratton Oakmont, engaged in rampant corruption and fraud on Wall Street, which ultimately led to his downfall.",
                            Price = 6.99,
                            ImageURL = "http://localhost/img/movies/wallsteetwolf.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = Enum.MovieCategory.Comedy,
                            CinemaId = 1,
                            DirectorId = 10
                        }
                    });
                    context.SaveChanges();
                }
                //Actor_Movie
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 15,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 18,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 19,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId = 9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 27,
                            MovieId = 10
                        },
                        new Actor_Movie()
                        {
                            ActorId = 28,
                            MovieId = 10
                        },
                        //DiCaprio
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 10
                        },
                        //Connelly
                        new Actor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 9
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
