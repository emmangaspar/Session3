using RestSharp;
using Session3.DataModels;
using Session3.Resources;
using Session3.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Helpers
{
    public class PetHelper
    {
        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.demoId();
            var postRequest = new RestRequest(Endpoints.PostPetId());

            //Send Post Request to create a new Pet
            postRequest.AddJsonBody(newPetData);
            var restResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
