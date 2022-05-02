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
    /// <summary>
    /// Plantilla para hacer la conexión con la base de datos diciendole que debe de usar
    /// </summary>
    public class LoggedUser
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
