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
        
        /// <summary>
        /// Conexión con la base de datos de MongoDB
        /// </summary>
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



        /// <summary>
        /// Método para agregar usuario
        /// </summary>
        /// <param name="nuevo"></param>
        public void insertLoggedUser(LoggedUser nuevo)
        {
            LoggedUsers.InsertOne(nuevo);

        }

        /// <summary>
        /// Método para llamar o buscar un usuario
        /// </summary>
        /// <returns></returns>
        public List<LoggedUser> obtenerLogggedUsers()
        {
            var filter = Builders<LoggedUser>.Filter.Empty;

            var lista = LoggedUsers.Find(filter);
            return lista.ToList();
        }

        /// <summary>
        /// Método para verificar que exista un usuario con las credenciales ingresadas
        /// </summary>
        /// <param name="password"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public LoggedUser? ObtenerloggedUser(string password, string usuario)
        {
            var lista = LoggedUsers.Find(d => d.Password == password && d.UserName == usuario);
            if (lista.Count() == 0)
            {
                return null;
            }
            return lista.ToList()[0];
        }

        /// <summary>
        /// Verificar que el usuario ingresado existe
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool LoggedUserExist(string usuario)
        {
            var lista = LoggedUsers.Find(d => d.UserName == usuario);
            return lista.ToList().Count != 0;
        }
        /// <summary>
        /// Modificar las credenciales de un usuario
        /// </summary>
        /// <param name="userToUpdate"></param>
        public void UpdateLoggedUser(LoggedUser userToUpdate)
        {
            this.LoggedUsers.ReplaceOne(d => d.Id == userToUpdate.Id, userToUpdate);
        }

        /// <summary>
        /// Eliminar usuario
        /// </summary>
        /// <param name="loggedUser"></param>
        public void DeleteLoggedUser(LoggedUser loggedUser)
        {
            this.LoggedUsers.DeleteOne(d => d.Id == loggedUser.Id);
        }
    }
}
