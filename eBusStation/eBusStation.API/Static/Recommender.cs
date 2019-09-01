using eBusStation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using eBusStation.PCL.Util;

namespace eBusStation.API.Static
{
    public class Recommender
    {
        private readonly eBusStation_Entities _database;
        private Dictionary<int, List<usp_mobile_Recommender_Load_Rates_Result>> relations = new Dictionary<int, List<usp_mobile_Recommender_Load_Rates_Result>>();
        public Recommender()
        {
            _database = new eBusStation_Entities();
        }
        public List<usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result> GetSimilarRelations(int relationId)
        {
            LoadRelations(relationId);

            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("relationId", relationId.ToString());

            List<usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result> recommenderRelations = new List<usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result>();

            HttpResponseMessage currentRelationRates = WebApiHelper.GetResult("/Recension/LoadRates/{relationId}", query);
            List<usp_mobile_Recommender_Load_Rates_Result> ratesForCurrentRelation = currentRelationRates.Content
                .ReadAsAsync<List<usp_mobile_Recommender_Load_Rates_Result>>().Result;

            List<usp_mobile_Recommender_Load_Rates_Result> commonRatesOne = new List<usp_mobile_Recommender_Load_Rates_Result>();
            List<usp_mobile_Recommender_Load_Rates_Result> commonRatesTwo = new List<usp_mobile_Recommender_Load_Rates_Result>();

            foreach (var item in relations)
            {
                foreach (var rate in ratesForCurrentRelation)
                {
                    if (item.Value.Where(x => x.KlijentiId == rate.KlijentiId).Count() > 0)
                    {
                        commonRatesOne.Add(rate);
                        commonRatesTwo.Add(item.Value.Where(x => x.KlijentiId == rate.KlijentiId).First());
                    }
                }
                double similarity = GetSimilarity(commonRatesOne, commonRatesTwo);
                if(similarity>0.5)
                {
                    query = new Dictionary<string, string>();
                    query.Add("relationId", item.Key.ToString());

                    HttpResponseMessage relationCityResponse = WebApiHelper.
                        GetResult("/Relation/Citie/{relationId}", query);
                    if (relationCityResponse.IsSuccessStatusCode)
                    {
                        usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result relation = relationCityResponse.Content
                            .ReadAsAsync<usp_mobile_Get_Cite_That_Line_Pass_By_Id_Result>().Result;
                        recommenderRelations.Add(relation);
                    }
                    commonRatesOne.Clear();
                    commonRatesTwo.Clear();
                }
            }
            return recommenderRelations;
        }

        private double GetSimilarity(List<usp_mobile_Recommender_Load_Rates_Result> commonRatesOne, List<usp_mobile_Recommender_Load_Rates_Result> commonRatesTwo)
        {
            if (commonRatesOne.Count() != commonRatesTwo.Count())
                return 0;
            double firstNumber = 0, secondNumber = 0, thirdNumber = 0;

            for(int i = 0; i < commonRatesOne.Count(); i++)
            {
                firstNumber = commonRatesOne[i].Ocjena * commonRatesTwo[i].Ocjena;
                secondNumber = commonRatesOne[i].Ocjena * commonRatesOne[i].Ocjena;
                thirdNumber = commonRatesTwo[i].Ocjena * commonRatesTwo[i].Ocjena;
            }
            secondNumber = Math.Sqrt(secondNumber);
            thirdNumber = Math.Sqrt(thirdNumber);

            double secondMultipliedThird = secondNumber * thirdNumber;
            if (secondMultipliedThird == 0)
                return 0;
            return firstNumber / secondMultipliedThird;
        }

        private void LoadRelations(int relationId)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("relationId", relationId.ToString());

            HttpResponseMessage activeRelationsResponse = WebApiHelper.
                 GetResult("/Relation/LoadRelationsDifferentThanCurrent/{relationId}", query);
            if (activeRelationsResponse.IsSuccessStatusCode)
            {
                List<usp_mobile_Recommnder_Load_Relations_Different_Than_Current_Result> activeRelations =
                     activeRelationsResponse.Content.ReadAsAsync<List<usp_mobile_Recommnder_Load_Relations_Different_Than_Current_Result>>().Result;

                foreach (var item in activeRelations)
                {
                    query = new Dictionary<string, string>();
                    query.Add("relationId", item.LinijeId.ToString());

                    HttpResponseMessage rates = WebApiHelper.GetResult("/Recension/LoadRates/{relationId}", query);
                    List<usp_mobile_Recommender_Load_Rates_Result> ratesRelations = rates.Content.ReadAsAsync<List<usp_mobile_Recommender_Load_Rates_Result>>().Result;
                    if (ratesRelations.Count() > 0)
                    {
                        if (!relations.Keys.Contains(item.LinijeId))
                        {
                            relations.Add(item.LinijeId, ratesRelations);
                        }
                    }
                }
            }
        }
    }
}