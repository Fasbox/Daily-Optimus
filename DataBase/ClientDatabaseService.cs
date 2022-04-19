using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using TrackerUI.DataBase;

namespace TrackerUI.DataBase
{
    public class ClientDatabaseService
    {
        private MongoCollectionBase<LoggedUser> LoggedUsers;
        public ClientDatabaseService()
        {
            var pass = "123";
            var databaseName = "daily_optimus";
            var collection = "loggedUser";
            var settings = MongoClientSettings.FromConnectionString($"mongodb+srv://admin:{pass}@cluster0.t2ush.mongodb.net/{databaseName}?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase(databaseName);
            LoggedUsers = (MongoCollectionBase<LoggedUser>?)database.GetCollection<LoggedUser>("loggedUser");
        }



        public void insertLoggedUser(LoggedUser nuevo)
        {
            LoggedUsers.InsertOne(nuevo);

        }

        public List<LoggedUser> obtenerLogggedUsers()
        {
            var filter = Builders<LoggedUser>.Filter.Empty;

            var lista = LoggedUsers.Find(filter);
            return lista.ToList();
        }

        public LoggedUser? ObtenerloggedUser(string password, string usuario)
        {
            var lista = LoggedUsers.Find(d => d.Password == password && d.UserName == usuario);
            if (lista.Count() == 0)
            {
                return null;
            }
            return lista.ToList()[0];
        }

        public bool LoggedUserExist(string usuario)
        {
            var lista = LoggedUsers.Find(d => d.UserName == usuario);
            return lista.ToList().Count != 0;
        }
        public void UpdateLoggedUser(LoggedUser userToUpdate)
        {
            this.LoggedUsers.ReplaceOne(d => d.Id == userToUpdate.Id, userToUpdate);
        }

        public void DeleteLoggedUser(LoggedUser loggedUser)
        {
            this.LoggedUsers.DeleteOne(d => d.Id == loggedUser.Id);
        }
    }
}
