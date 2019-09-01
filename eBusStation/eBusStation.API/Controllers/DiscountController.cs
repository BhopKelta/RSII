using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eBusStation.API.Controllers
{
    public class DiscountController : ApiController
    {
        private eBusStation_Entities _database;

        public DiscountController()
        {
            _database = new eBusStation_Entities();
        }
        [HttpGet]
        [Route("api/Discount/GetDiscountsOnLine/{lineId}")]
        public List<usp_mobile_Get_Line_Discounts_Result>GetDiscount(int lineId)
        {
            return _database.usp_mobile_Get_Line_Discounts(lineId).ToList();
        }
        [HttpPost]
        [Route("api/Discount/DiscountOnLine")]
        public IHttpActionResult AddDiscount([FromBody]PopustNaLiniji discountOnLine)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            Popusti discount = discountOnLine.Popusti;

            int discountId = _database.Add_Discount(discount.Postotak, discount.DatumVazenjaPopusta);
            _database.Add_Discount_On_Line(discountId, discountOnLine.LinijeId, discountOnLine.Opis);
            return Ok();
        }
    }
}
