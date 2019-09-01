using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class LoginController : ApiController
    {
        private eBusStation_Entities _database;
        public LoginController()
        {
            _database = new eBusStation_Entities();
        }
        [Route("api/Login/Authenticate")]
        [HttpGet]
        public usp_Get_User_Result AuthenticateEmployee(string username, string password)
        {
           usp_Get_User_Result user = _database.Get_UserByCredentials(username).SingleOrDefault();
            if (user != null)
            {
                string hash = user.Hash;

                byte[] hashBytes = Convert.FromBase64String(hash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash2 = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash2[i])
                        throw new UnauthorizedAccessException();
            }
            return user;
        }
        [Route("api/Login/Authenticate_Mobile_User")]
        [HttpGet]
        public usp_mobile_Get_User_Result AuthenticateMobileUser(string username)
        {
            return _database.usp_mobile_Get_User(username).FirstOrDefault();
        }
        [Route("api/Login/EditHash")]
        [HttpGet]
        public void EditUsersHash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            _database.usp_Edit_Users_Hash(savedPasswordHash);
        }
        [Route("api/Login/AddUser")]
        [HttpPost]
        public IHttpActionResult AddMobileUser([FromBody]Korisnici user)
        {
            _database.usp_mobile_Add_User(user.username, user.Hash, user.Ime, user.Prezime, user.datumRodjenja, user.Zanimanje, user.Email,
                user.isValid, user.UlogeId, user.Discriminator, user.Spol,user.Salt);
            return Ok();
        }
    }
}
