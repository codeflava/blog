using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JustBlog.Models
{
	public class Category
	{
		Category()
		{
			Posts = new List<Post>();
		}
		[BsonElement("id")]
		public ObjectId Id { get; set; }
		[BsonElement("name")]
		public string Name { get; set; }

		public IEnumerable<Post> Posts { get; set; }
		public DateTime CreatedDate
		{
			get { return Id.CreationTime; }
		}
	}
}