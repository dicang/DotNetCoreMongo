using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories.Context;
using MongoDB.Bson;

namespace Mongo.Api.Repositories
{
	public class UserRepository : IUserRepository
	{

		private readonly IRollerContext _context;

		public UserRepository(IRollerContext context)
		{
			_context = context;
		}

		public Task<IEnumerable<User>> GetAll()
		{
			return null;
		}

		public Task<User> Get(ObjectId id)
		{
			return null;
		}

		public Task<User> Update(User user)
		{
			return null;
		}

		public Task<User> Add(User user)
		{
			return null;
		}
	}
}