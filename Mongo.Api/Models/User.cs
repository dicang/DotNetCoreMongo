using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Api.Models
{
	[BsonIgnoreExtraElements]
	public class User
	{
		[BsonId]
		public ObjectId Id { get; set; }

		public string UserName { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Role Role{ get; set; }
	}
}