using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },


                        new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
//Sisestada SolarPlanets projekti kääbusplaneedid: Pluuto, Ceres, Haumea, MakeMake ja Eris.
//Planeetide kohta leiate infot: https://science.nasa.gov/dwarf-planets/
//Planeetide pildid peavad olema sama tegumoega nagu eelmised.
//Otsida piltidele asendused, mis ei näita.
//Kui töö on valmis, siis näidata ette.
            new()
            {
                Name = "Pluto",
                Subtitle = " The In-Between (Dwarf) Planet",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies " +
                "beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It" +
                " is the largest known trans-Neptunian object by volume, by a small margin, but is slightly less massive than Eris. Like " +
                "other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has" +
                " only one sixth the mass of Earth's moon, and one third its volume. Pluto was recognized as a planet until 2006. ",
                AccentColorStart = Color.FromArgb("#9b6547"),
                AccentColorEnd = Color.FromArgb("#efb493"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA19702/PIA19702~large.jpg%3Fw=1920%26h=1920%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg%3Fw=855%26h=582%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA11707/PIA11707~large.jpg%3Fw=1920%26h=960%26fit=clip%26crop=faces%252Cfocalpoint"
                }

            },
              new()
            {
                Name = "Ceres",
                Subtitle = " The Insider Dwarf Planet",
                HeroImage = "ceres.webp",
                Description = "Ceres (pronounced /ˈsɪəriːz/ SEER-eez), minor-planet designation 1 Ceres, is a dwarf " +
                "planet in the middle main asteroid belt between the orbits of Mars and Jupiter. It was the first asteroid" +
                " discovered on 1 January 1801, by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily and announced" +
                " as a new planet. Ceres was later classified as an asteroid and then a dwarf planet, the only one always " +
                "inside Neptune's orbit. ",
                AccentColorStart = Color.FromArgb("#497873"),
                AccentColorEnd = Color.FromArgb("#74b5ae"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/b4a4f4c3-269e-4f37-a94d-45d86cf0cb52/ceres_occatorcrater_square.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdUZsIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--ca667488ed16597e35eaab71acd42034ca4f56c2/PIA20180-16-640x350.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2016/05/Ceres_-_Oxo_and_Haulani_craters.png"

                }

            },
            new()
            {
                Name = "Haumea",
                Subtitle = " The Fastest Dwarf Planet",
                HeroImage = "haumea.webp",
                Description = "Haumea (minor-planet designation 136108 Haumea) is a dwarf planet located beyond Neptune's orbit." +
                " It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory in the United " +
                "States and disputably also in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in " +
                "Spain. On September 17, 2008, it was named after Haumea, the Hawaiian goddess of childbirth, under the expectation " +
                "by the International Astronomical Union (IAU) that it would prove to be a dwarf planet. Nominal estimates make it " +
                "the third-largest known trans-Neptunian object, after Eris and Pluto, and approximately the size of Uranus's moon Titania. ",
                AccentColorStart = Color.FromArgb("#494746"),
                AccentColorEnd = Color.FromArgb("#6d6d6c"),
                Images = new()
                {
                    "https://scx2.b-cdn.net/gfx/news/hires/2017/59de5fc415107.jpg",
                    "https://static.wikia.nocookie.net/planet-archives/images/2/2d/Haumea.png/revision/latest?cb=20131012022005"
                }

            },
             new()
            {
                Name = "Makemake",
                Subtitle = " The Brightest Dwarf Planet",
                HeroImage = "makemake.webp",
                Description = "Makemake[e] (minor-planet designation 136472 Makemake) is a dwarf planet and the second-largest " +
                "of what are known as the classical population of Kuiper belt objects, with a diameter approximately that of " +
                "Saturn's moon Iapetus, or 60% that of Pluto.[24][25] It has one known satellite.[26] Its extremely low average " +
                "temperature, about 40 K (−230 °C), means its surface is covered with methane, ethane, and possibly nitrogen ices.",
                AccentColorStart = Color.FromArgb("#835a44"),
                AccentColorEnd = Color.FromArgb("#b58b74"),
                Images = new()
                {
                    "https://astrophotographylens.com/cdn/shop/articles/Makemake.jpg?v=1693095521",
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
                }

            },
            new()
            {
                Name = "Eris",
                Subtitle = " The Goddess of Chaos",
                HeroImage = "eris.webp",
                Description = "Eris (minor-planet designation 136199 Eris) is the most massive and second-largest known " +
                "dwarf planet in the Solar System. It is a trans-Neptunian object (TNO) in the scattered disk and " +
                "has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team " +
                "led by Mike Brown and verified later that year. In September 2006, it was named after the Greco–Roman " +
                "goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the " +
                "sixteenth-most massive overall in the Solar System (counting moons). It is also the largest known object " +
                "in the solar system that has not been visited by a spacecraft. Eris has been measured at 2,326 ± 12 kilometers (1,445 ± 7 mi)" +
                " in diameter;[12] its mass is 0.28% that of the Earth and 27% greater than that of Pluto, although Pluto is slightly larger by " +
                "volume. Both Eris and Pluto have a surface area that is comparable to the area of Russia or South America. ",
                AccentColorStart = Color.FromArgb("#4e8187"),
                AccentColorEnd = Color.FromArgb("#91cad1"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA03034/PIA03034~orig.jpg%3Fw=603%26h=200%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://i.cbc.ca/1.1936894.1381378170!/httpImage/hi-852-eris-eso1142a.jpg"
                }

            }

        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}