using System.Net.Http.Headers;
using Newtonsoft.Json;

public class service
{
        const string end = "https://jsonmock.hackerrank.com/api/football_matches";

        private async Task<Application> getDados(string team, int year, int page = 1)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync($"{end}?year={year}&team1={team}&page={page}");
            if(response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var dadosTime = JsonConvert.DeserializeObject<Application>(responseBody);
                return dadosTime;
            }
            return null;
        }
        private int getTotalGoals(string nomeTime, IList<Data> dadosResposta)
        {
            var gols = 0;
            var contado = false;
            foreach(var game in dadosResposta)
            {
                if (game.team1 == nomeTime)
                {
                    gols += int.Parse(game.team1goals); 
                    contado = true;
                }

                if(game.team2 == nomeTime && !contado)
                {
                    gols += int.Parse(game.team2goals); 
                }
                contado = false;
            }
            return gols;
        }
}