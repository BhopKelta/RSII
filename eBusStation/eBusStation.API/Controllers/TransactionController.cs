using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class TransactionController : ApiController
    {
        private eBusStation_Entities _database;
        public TransactionController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpPost]
        [Route("api/Transaction/AddNewTransaction")]
        public decimal? AddTransaction([FromBody]Transakcije transaction)
        {
           return _database.usp_mobile_Add_User_Transaction(transaction.datumKupovine, transaction.brojTransakcije,
                transaction.Status, transaction.otkazano, transaction.KlijentiId, transaction.KarticaId).First();
        }
        [HttpPost]
        [Route("api/Transaction/AddTransactionDetails")]
        public IHttpActionResult AddDetailsToTransaction([FromBody]TransakcijaStavke details)
        {
            _database.usp_mobile_Add_User_Transaction_Detail(details.TransakcijaId, details.KartaId, details.Kolicina, details.UkupnaCijena);
            return Ok();
        }
        [HttpGet]
        [Route("api/Transaction/{userId}/Transactions")]
        public List<usp_mobile_Get_All_User_Transactions_Result>GetTransactions(int userId)
        {
            return _database.usp_mobile_Get_All_User_Transactions(userId).ToList();
        }
        [HttpGet]
        [Route("api/Transaction/{userId}/FinishedTransactions")]
        public List<usp_mobile_Get_All_User_Finished_Travels_Result>GetFinishedTransactions(int userId)
        {
            return _database.usp_mobile_Get_All_User_Finished_Travels(userId).ToList();
        }
        [HttpGet]
        [Route("api/Transaction/{transactionId}/Cancel")]
        public IHttpActionResult CancelTransaction(int transactionId)
        {
            _database.usp_mobile_Cancel_Transaction(transactionId);
            return Ok();
        }
    }
}
