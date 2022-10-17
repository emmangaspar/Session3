using Session3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Tests.TestData
{
    public class GeneratePet
    {
        public static PetModel demoId()
        {
            Random r = new Random();
            long rlong = r.Next(0, 100);

            List<Tag> tags = new List<Tag>();
            tags.Add(new Tag()
            {
                Id = rlong,
                Name = "SampleTag"
            });

            PetModel petModel = new PetModel()
            {
                Id = rlong,
                Category = new Category()
                {
                    Id = rlong,
                    Name = "Dogs"
                },
                Name = "RugDog",
                PhotoUrls = new List<string> { "" },
                Tags = tags,
                Status = "Available"
            };
            return petModel;
        }
    }
}
