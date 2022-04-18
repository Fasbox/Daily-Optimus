using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TrackerUI.DataBase
{
    public class loggedUsers
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        [BsonElement("usuario")]
        public string UserName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }


        [BsonElement("password")]
        public string Password { get; set; }

    }
}
