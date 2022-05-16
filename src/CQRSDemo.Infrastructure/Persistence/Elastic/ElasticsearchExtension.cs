using Elasticsearch.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace CQRSDemo.Infrastructure.Persistence.Elastic
{
    public static class ElasticsearchExtension
    {
        public static IServiceCollection AddElasticsearch(this IServiceCollection services, IConfiguration configuration)
        {
            var url = configuration["Elasticsearch:elasticUrl"];
            var defaultIndex = configuration["Elasticsearch:indexName"];

            var pool = new SingleNodeConnectionPool(new Uri(url));
            var settings = new ConnectionSettings(pool, sourceSerializer: Nest.JsonNetSerializer.JsonNetSerializer.Default)
                .DefaultIndex(defaultIndex).DefaultFieldNameInferrer(o => o);

            AddDefaultMappings(settings);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);

            return services;
        }


        private static void AddDefaultMappings(ConnectionSettings settings)
        {
            // set mapping settings
        }
    }
}
