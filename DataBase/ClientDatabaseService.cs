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
        private MongoCollectionBase<loggedUsers> LoggedUsers;
        public ClientDatabaseService()
        {
            var databaseName = "daily_optimus";
            var client = new MongoClient("mongodb+srv://Fasbox:123@cluster0.t2ush.mongodb.net/loggedUsers");
            var database = client.GetDatabase(databaseName);


            var loggedUsersDB = database.GetCollection<loggedUsers>("loggedUsers");
        }



        public void insertLoggedUser(loggedUsers nuevo)
        {
            LoggedUsers.InsertOne(nuevo);

        }

        public List<loggedUsers> obtenerLogggedUsers()
        {
            var filter = Builders<loggedUsers>.Filter.Empty;

            var lista = LoggedUsers.Find(filter);
            return lista.ToList();
        }

        public loggedUsers? ObtenerloggedUser(string password, string usuario)
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
        public void UpdateLoggedUser(loggedUsers userToUpdate)
        {
            this.LoggedUsers.ReplaceOne(d => d.Id == userToUpdate.Id, userToUpdate);
        }

        public void DeleteLoggedUser(loggedUsers loggedUser)
        {
            this.LoggedUsers.DeleteOne(d => d.Id == loggedUser.Id);
        }
    }
}
