using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories.Context;
using MongoDB.Bson;

namespace Mongo.Api.Repositories
{
	public class RoleRepository : IRoleRepository
	{

		private readonly IRollerContext _context;

		public RoleRepository(IRollerContext context)
		{
			_context = context;
		}

		public Task<IEnumerable<Role>> GetAll()
		{
			return null;
		}

		public Task<Role> Get(ObjectId id)
		{
			return null;
		}

		public Task<Role> Update(Role role)
		{
			return null;
		}

		public Task<Role> Add(Role role)
		{
			return null;
		}
	}
}