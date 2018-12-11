using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories;
using MongoDB.Bson;

namespace Mongo.Api.Services
{
	public class UserService : IUserService
	{
		public IUserRepository _repo;

		public UserService(IUserRepository repo)
		{
			_repo = repo;
		}

		public Task<IEnumerable<User>> GetAll()
		{
			return _repo.GetAll();
		}

		public Task<User> Get(ObjectId id)
		{
			return _repo.Get(id);
		}

		public Task<User> Update(User user)
		{
			return _repo.Update(user);
		}

		public Task<User> Add(User user)
		{
			return _repo.Add(user);
		}
	}
}