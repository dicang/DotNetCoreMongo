using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;

namespace Mongo.Api.Repositories
{
	public interface IRollerCoasterRepository : ICrudRepo<RollerCoaster>
	{
		Task<RollerCoaster> GetRollerCoaster(string name);
	}
}