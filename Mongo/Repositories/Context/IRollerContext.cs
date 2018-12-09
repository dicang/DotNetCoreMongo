using Mongo.Api.Models;
using MongoDB.Driver;

namespace Mongo.Api.Repositories.Context
{
	public interface IRollerContext
	{
		IMongoCollection<RollerCoaster> RollerCoasters { get; }
	}
}