using Entity.Dtos.Global;

namespace Entity.Dtos.Security.Person
{
    public class PersonDto : ABaseDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
    }
}
