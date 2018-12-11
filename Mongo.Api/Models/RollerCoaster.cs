using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Api.Models
{
	[BsonIgnoreExtraElements]
	public class RollerCoaster
	{
		[BsonId]
		public ObjectId Id { get; set; }

		public int RollerCoasterId { get; set; }

		public string Name { get; set; }

		public string Park { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Country { get; set; }

		public string Construction { get; set; }

		public string Region { get; set; }
		
		public string Type { get; set; }

		public string Height { get; set; }

		public string Speed { get; set; }

		public string Length { get; set; }

		public string Inversions { get; set; }

		public string NumberOfInversions { get; set; }

		public string Duration { get; set; }

		public string GForce { get; set; }

		public string OpenedYear { get; set; }
	}
}