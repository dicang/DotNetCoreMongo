using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using Mongo.Api.Repositories;

namespace Mongo.Api.Services
{
	public class RollerService : IRollerService
	{
		private readonly IRollerRepository _repo;

		public RollerService(IRollerRepository repo)
		{
			_repo = repo;
		}

		public Task<IEnumerable<RollerCoaster>> GetAll()
		{
			return _repo.GetAll();
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