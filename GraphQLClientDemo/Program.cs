using System;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLClientDemo
{
    public class Program
    {
        private const string GraphQlEndpoint = "http://localhost:5000/graphql";
        private static IStarWarsClient _starWarsClient;

        public static void Main(string[] args)
        {
            var serviceCollection = Init();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            _starWarsClient = services.GetRequiredService<IStarWarsClient>();

            FetchHeroes(Episode.NewHope);
            FetchHeroes(Episode.Empire);

        }

        private static void FetchHeroes(Episode episode)
        {
            var result = _starWarsClient.GetHeroAsync(episode).Result;
            var hero = result.Data?.Hero;

            switch (hero)
            {
                case ISomeHuman someHuman:
                    Console.WriteLine($"Name of some human: {someHuman.Name}");
                    break;
                case ISomeDroid someDroid:
                    Console.WriteLine($"Name of some droid: {someDroid.Name}");
                    break;
            }
        }

        private static ServiceCollection Init()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient(
                "StarWarsClient",
                c => c.BaseAddress = new Uri(GraphQlEndpoint));
            serviceCollection.AddStarWarsClient();

            return serviceCollection;
        }
    }
}