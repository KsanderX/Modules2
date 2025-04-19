using Lab7.Models;


namespace Lab7.ViewModels
{
    public class PeopleViewModelSimple
    {
        public List<PersonModelSimple> People { get; set; }
        public PersonModelSimple SelectedPerson { get; set; }
        public PeopleViewModelSimple() 
        {
            People = new List<PersonModelSimple>
            {
                new PersonModelSimple {Id = 1, Name = "Sanchez", Birthday = new(2005, 2, 27), Description = "Sportic"},
                new PersonModelSimple {Id = 2, Name = "George", Birthday = new(2005, 4, 29), Description = "The best swordsman"},
                new PersonModelSimple {Id = 3, Name = "Alexey", Birthday = new(2005, 2, 11), Description = "Top dude"}
            };
            SelectedPerson = People.First();
        }
    }
}
