using Microsoft.Extensions.Options;
using Mongo.Api.Models;
using Mongo.Api.Settings;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Mongo.Api.Repositories.Context
{
	public class RollerContext : IRollerContext
	{
		private readonly IMongoDatabase _context;

		public RollerContext(IOptions<DbSettings> settings)
		{
			var client = new MongoClient(settings.Value.ConnectString);
			_context = client.GetDatabase(settings.Value.Database);
			var pack = new ConventionPack {new CamelCaseElementNameConvention()};
			ConventionRegistry.Register("camel case", pack, t => true);
		}

		public IMongoCollection<RollerCoaster> RollerCoasters =>
			_context.GetCollection<RollerCoaster>("_coasters");
	}
}


