namespace StrikeBuilderMVC.Models
{
    public class MockStrikesRepository : IMockStrikesRepository
    {
        public IEnumerable<Strike> AllStrikes => new List<Strike> 
        {
            new Strike {Id = 1, Name="Jab", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit.", LongDescription="Lorem ipsum odor amet, consectetuer adipiscing elit. Nec turpis donec magna nisi habitant praesent orci conubia. Feugiat ex blandit mollis interdum elit nascetur. Ut integer vestibulum, ridiculus felis suscipit ac dignissim. Ultricies etiam cursus felis tellus elementum dolor felis volutpat. Taciti feugiat morbi lobortis maximus mollis malesuada? Conubia aliquam in dignissim aliquet ligula, fusce nunc imperdiet. Purus consectetur diam hendrerit tempor a varius diam fermentum. Inceptos proin ex congue accumsan hac egestas. Molestie lobortis parturient per malesuada tortor consectetur nibh justo. Quam dignissim nibh semper semper hendrerit velit. Himenaeos sociosqu vel lectus venenatis senectus justo habitasse sagittis. Elementum in litora senectus nam sodales aenean lacus. Id inceptos lorem metus ad nibh posuere habitant arcu. Fringilla nullam malesuada aliquet erat nunc neque semper pretium. Ac mauris vestibulum in justo sodales amet nunc leo. Et quisque ultricies est dui rhoncus vehicula. Curabitur condimentum massa tortor aliquet class ultrices.", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fblogs.rdxsports.com%2Fwp-content%2Fuploads%2F2022%2F09%2Fjab-1.jpg&f=1&nofb=1&ipt=b7e6aba21233d323001d30c3594bbf4b26aceccbf03e47b0ead3f5f668a4b045&ipo=images", OriginDescription="Lorem ipsum odor amet, consectetuer adipiscing elit. Nec turpis donec magna nisi habitant praesent orci conubia. Feugiat ex blandit mollis interdum elit nascetur. Ut integer vestibulum, ridiculus felis suscipit ac dignissim. Ultricies etiam cursus felis tellus elementum dolor felis volutpat. Taciti feugiat morbi lobortis maximus mollis malesuada? Conubia aliquam in dignissim aliquet ligula, fusce nunc imperdiet. Purus consectetur diam hendrerit tempor a varius diam fermentum. Inceptos proin ex congue accumsan hac egestas. Molestie lobortis parturient per malesuada tortor consectetur nibh justo. Quam dignissim nibh semper semper hendrerit velit. Himenaeos sociosqu vel lectus venenatis senectus justo habitasse sagittis. Elementum in litora senectus nam sodales aenean lacus. Id inceptos lorem metus ad nibh posuere habitant arcu. Fringilla nullam malesuada aliquet erat nunc neque semper pretium. Ac mauris vestibulum in justo sodales amet nunc leo. Et quisque ultricies est dui rhoncus vehicula. Curabitur condimentum massa tortor aliquet class ultrices."},
            new Strike {Id = 2, Name="Cross", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
            new Strike {Id = 3, Name="Left Hook", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
            new Strike {Id = 4, Name="Right Hook", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
            new Strike {Id = 5, Name="Uppercut", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
            new Strike {Id = 6, Name="Left Round Kick", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
            new Strike {Id = 7, Name="Right Round Kick", ShortDescription="Lorem ipsum odor amet, consectetuer adipiscing elit."},
        };

        public List<Strike> GetAllStrikes()
        {
            return AllStrikes.ToList();
        }

        public Strike GetStrikeById(int id)
        {
            return AllStrikes.FirstOrDefault(s => s.Id == id);
        }
    }
}
