using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories;
using MongoDB.Bson;

namespace Mongo.Api.Services
{
	public class RollerCoasterService : IRollerCoasterService
	{
		private readonly IRollerCoasterRepository _repo;

		public RollerCoasterService()
		{
		}

		public RollerCoasterService(IRollerCoasterRepository repo)
		{
			_repo = repo;
		}

		public Task<IEnumerable<RollerCoaster>> GetAll()
		{
			return _repo.GetAll();
		}

		public Task<RollerCoaster> Get(ObjectId id)
		{
			return _repo.Get(id);
		}

		public Task<RollerCoaster> Update(RollerCoaster role)
		{
			return _repo.Update(role);
		}

		public Task<RollerCoaster> Add(RollerCoaster role)
		{
			return _repo.Add(role);
		}

		public Task<RollerCoaster> GetRollerCoaster(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new Exception("Parameter name cannot be empty.");
			}

			return _repo.GetRollerCoaster(name);
		}
	}
}