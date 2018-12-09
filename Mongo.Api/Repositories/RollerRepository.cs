using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories.Context;
using MongoDB.Driver;

namespace Mongo.Api.Repositories
{
	public class RollerRepository : IRollerRepository
	{
		private readonly IRollerContext _context;

		public RollerRepository(IRollerContext context)
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