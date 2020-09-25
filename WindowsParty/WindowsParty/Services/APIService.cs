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

                var response = await _httpClient.PostAsync(ApiPaths.LoginPath, content);

                var strContent = response.Content.ReadAsStringAsync().Result;
                JObject responseJson = JObject.Parse(strContent);
                if (!String.IsNullOrWhiteSpace((string)responseJson["message"]))
                {
                    MessageBox.Show((string)responseJson["message"], "Warning");
                    return false;
                }
                else
                    UserInfo.SetUserInfo(username, (string)responseJson["token"]);
                return true;
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
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserInfo.Token);

                var response =  await httpClient.GetAsync(ApiPaths.ServerListPath);

                var strContent = response.Content.ReadAsStringAsync().Result;
                if(response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    JObject responseJson = JObject.Parse(strContent);

                    if (!String.IsNullOrWhiteSpace((string)responseJson["message"]))
                    {
                        MessageBox.Show((string)responseJson["message"], "Warning");
                        return "";
                    }
                }
                return strContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: occured:" + ex.Message);
                return "";
            }
        }
    }
}
