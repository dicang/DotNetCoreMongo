using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Mongo.Api.Services
{
	public interface ICrudService<T>
	{
		Task<IEnumerable<T>> GetAll();

		Task<T> Get(ObjectId id);

		Task<T> Update(T role);

		Task<T> Add(T role);
	}
}