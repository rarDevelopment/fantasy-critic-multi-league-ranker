using System.Net.Http.Json;

namespace FantasyCriticMultiLeagueRanker;

internal partial class Program
{
    private const string LeagueIdKeyword = "{{LEAGUE_ID}}";
    private const string YearKeyword = "{{YEAR}}";

    private const string LeagueUrlTemplate = "https://www.fantasycritic.games/api/League/GetLeagueYear?leagueID=" + LeagueIdKeyword + "&year=" + YearKeyword;

    static async Task Main(string[] args)
    {
        var leagueIds = new List<string>
        {

        };

        const string year = "2023";

        var allPublishers = new List<PublisherRanking>();

        foreach (var leagueId in leagueIds)
        {
            try
            {
                var leagueYearData = await GetLeagueYearData(leagueId, year);
                var publishers = leagueYearData.Publishers;

                allPublishers.AddRange(publishers.Select(p => new PublisherRanking(
                    p.PublisherName.Trim(),
                    p.PlayerName,
                    p.LeagueName,
                    p.TotalFantasyPoints)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        var rankedPublishers = allPublishers.OrderByDescending(p => p.Points);

        int rank = 0;
        foreach (var p in rankedPublishers)
        {
            rank++;
            Console.WriteLine($"{rank}. {p.UserName} ({p.LeagueName}): **{p.Points:F1}**");
        }
    }

    private static async Task<Root> GetLeagueYearData(string leagueId, string year)
    {
        var leagueUrl = LeagueUrlTemplate.Replace(LeagueIdKeyword, leagueId).Replace(YearKeyword, year);

        var client = new HttpClient(new HttpClientHandler());
        var response = await client.GetAsync(new Uri(leagueUrl));
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error retrieving League Year data: Status: {response.StatusCode}: {response.Content}");
        }

        var fcResponse = await response.Content.ReadFromJsonAsync<Root>();
        return fcResponse ?? throw new Exception($"Error retrieving League Year data: Empty response when reading JSON");
    }
}