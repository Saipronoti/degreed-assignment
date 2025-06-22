namespace degreed_assignment.Models
{
 public enum JokeSize
    {
        Short,
        Medium,
        Long
    }
public class DadJokeResponseModel
{
        public string Id { get; set; }
        public string Joke { get; set; }
        public int Status { get; set; }

         public JokeSize Size
        {
            get
            {
                var wordCount = Joke.Split(' ').Length;
                if (wordCount < 10) return JokeSize.Short;
                if (wordCount < 20) return JokeSize.Medium;
                return JokeSize.Long;
            }
        }
}
}