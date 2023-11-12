namespace FantasyCriticMultiLeagueRanker;

internal partial class Program
{
    public class PublisherRanking
    {
        public PublisherRanking(string publisherName, string userName, string leagueName, double points)
        {
            PublisherName = publisherName;
            UserName = userName;
            LeagueName = leagueName;
            Points = points;
        }

        public string PublisherName { get; set; }
        public string UserName { get; set; }
        public string LeagueName { get; set; }
        public double Points { get; set; }
    }
}