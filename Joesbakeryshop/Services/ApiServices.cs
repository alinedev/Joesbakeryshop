using Joesbakeryshop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Joesbakeryshop.Services
{
    public class ApiServices
    {
        public async Task<List<Menu>> GetMenu()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://joesbakery.azurewebsites.net/api/menus");
            return JsonConvert.DeserializeObject<List<Menu>>(response);
        }
        public async Task<bool> ReserveTable(Reservation reservation)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("https://joesbakery.azurewebsites.net/api/Reservations", content);
            return response.IsSuccessStatusCode;
        }

        internal static Task RegisterUser(string text1, string text2, object text3)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterUser(string name, string email,string password)
        {
            var register = new Register()
            {
                Name = name,
                Email = email,
                Password = password
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(register);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://joesbakery.azurewebsites.net/api/Register", content);
            if (!response.IsSuccessStatusCode) return false;
            var jsonResult = await response.Content.ReadAsStringAsync();
            //JsonConvert.DeserializeObject<Token>(jsonResult);
            return true;
        }
        public static async Task <bool>Login(string email,string password)
        {
            var login = new Login()
            {
                Email = email,
                Password = password
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("https://joesbakery.azurewebsites.net/api/Login", content);
            if (!response.IsSuccessStatusCode) return false;
            var jsonResult = await response.Content.ReadAsStringAsync();
            //JsonConvert.DeserializeObject<Token>(jsonResult);
            return true;

        }
    }
}
