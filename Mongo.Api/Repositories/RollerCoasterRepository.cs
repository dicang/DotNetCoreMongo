using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories.Context;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo.Api.Repositories
{
	public class RollerCoasterRepository : IRollerCoasterRepository
	{
		private readonly IRollerContext _context;

		public RollerCoasterRepository(IRollerContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<RollerCoaster>> GetAll()
		{
			return await _context
				.RollerCoasters
				.Find(_ => true)
				.ToListAsync();
		}

		public Task<RollerCoaster> Get(ObjectId id)
		{
			return null;
		}

		public Task<RollerCoaster> Update(RollerCoaster role)
		{
			return null;
		}

		public Task<RollerCoaster> Add(RollerCoaster role)
		{
			return null;
		}


		public async Task<RollerCoaster> GetRollerCoaster(string name)
		{
			var filter = Builders<RollerCoaster>.Filter.Eq(xx => xx.Name, name);

			return await _context
				.RollerCoasters
				.Find(filter)
				.FirstOrDefaultAsync();
		}
	}
}