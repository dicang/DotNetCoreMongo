using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;

namespace Mongo.Api.Services
{
	public interface IRollerCoasterService : ICrudService<RollerCoaster>
	{
		Task<RollerCoaster> GetRollerCoaster(string name);
	}
}