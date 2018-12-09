using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;

namespace Mongo.Api.Repositories
{
	public interface IRollerRepository 
	{
		Task<IEnumerable<RollerCoaster>> GetAll();
		Task<RollerCoaster> GetRollerCoaster(string name);
	}
}