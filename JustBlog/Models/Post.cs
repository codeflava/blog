using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JustBlog.Models
{
	public class Post
	{
		[BsonElement("id")]
		public ObjectId Id { get; set; }
		[BsonElement("title")]
		public string Title { get; set; }
		[BsonElement("content")]
		public string Content { get; set; }

		public Category Category { get; set; }

		public DateTime CreatedDate
		{
			get { return Id.CreationTime; }
		}
	}
}