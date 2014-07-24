using System;
using System.Collections.Generic;
using JustBlog.Models;
using MongoDB.Driver;

namespace JustBlog.DataAccess
{
	public class PostRepository
	{
		private const string ConnectionString = "mongodb://localhost";
		private MongoCollection<Post> _posts;
		private MongoClient _client;
		private MongoServer _server;
		private MongoDatabase _db;

		internal PostRepository()
		{
			Initialize();
		}
		

		public Post Get(int id)
		{
			return _posts.FindOneById(id);
		}

		public IEnumerable<Post> GetAll()
		{
			return _posts.FindAll();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Insert(Post entity)
		{
			_posts.Insert(entity);
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}
		public void Initialize()
		{
			_client = new MongoClient(ConnectionString);
			_server = _client.GetServer();
			_db = _server.GetDatabase("BlogDB");
			_posts = _db.GetCollection<Post>("Posts");
		}
	}
}
