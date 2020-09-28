using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsParty.Global;
using WindowsParty.Models;

namespace WindowsParty.Services
{
    public interface IAPIService
    {
        Task<bool> LogIn(string username, string password);
        Task<string> GetServerList();
    }
    public class APIService: IAPIService
    {
        private readonly HttpClient _httpClient;
        public APIService() 
        {
            _httpClient = new HttpClient ();
            _httpClient.DefaultRequestHeaders.Clear();
        }
        public async Task<bool> LogIn(string username, string password)
        {
            try
            {
                JObject jsonLogin = JObject.FromObject(new
                {
                    username = username,
                    password = password,
                });

                var content = new StringContent(jsonLogin.ToString(), Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await _httpClient.PostAsync(ApiPaths.LoginPath, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JObject responseJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

                        UserInfo.SetUserInfo(username, (string)responseJson["token"]);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: occured:" + ex.Message);
                return false;
            }
        }
        public async Task<string> GetServerList()
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserInfo.Token);

                using(HttpResponseMessage response = await _httpClient.GetAsync(ApiPaths.ServerListPath))
                {
                    if(response.IsSuccessStatusCode)
                    {
                        var resonseResult = response.Content.ReadAsStringAsync().Result;

                        return resonseResult;
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase);
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: occured:" + ex.Message);
                return "";
            }
        }
    }
}
