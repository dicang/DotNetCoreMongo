using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories;
using MongoDB.Bson;

namespace Mongo.Api.Services
{
	public class RoleService : IRoleService
	{
		public RoleService(IRoleRepository repo)
		{
			_repo = repo;
		}

		public IRoleRepository _repo;

		public Task<IEnumerable<Role>> GetAll()
		{
			return _repo.GetAll();
		}

		public Task<Role> Get(ObjectId id)
		{
			return _repo.Get(id);
		}

		public Task<Role> Update(Role role)
		{
			return _repo.Update(role);
		}

		public Task<Role> Add(Role role)
		{
			return _repo.Add(role);
		}
	}
}