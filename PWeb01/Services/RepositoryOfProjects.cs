using PWeb01.Models;

namespace PWeb01.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>() {
                new ClassProjects {
                    Title = "ASP.net",
                    Description = "WEB realizada con ASP.NET Core",
                    Link = "https://es.wikipedia.org/wiki/ASP.NET",
                    ImageURL = "/img/asp1.jpg"
                    },
                new ClassProjects {
                    Title = "Java Script",
                    Description = "Proyecto creado en Java Script",
                    Link = "https://es.wikipedia.org/wiki/JavaScript",
                    ImageURL = "/img/java.jpg"
                    },
                new ClassProjects {
                    Title = "PHP",
                    Description = "Ecommerce realizado en PHP",
                    Link = "https://es.wikipedia.org/wiki/PHP",
                    ImageURL = "/img/php.jpg"
                    }
                
            };
        }

    }
}
