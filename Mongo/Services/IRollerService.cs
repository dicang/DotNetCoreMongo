using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;

namespace Mongo.Api.Services
{
	public interface IRollerService
	{
		Task<IEnumerable<RollerCoaster>> GetAll();
		Task<RollerCoaster> GetRollerCoaster(string name);
	}
}