using System.Collections.Generic;
using System.Threading.Tasks;
using Mongo.Api.Models;
using MongoDB.Bson;

namespace Mongo.Api.Services
{
	public interface IUserService	: ICrudService<User>
	{
	}
}