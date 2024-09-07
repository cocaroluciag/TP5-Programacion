﻿using AppFakeStore2.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using AppFakeStore2.Utils;
using System.Net.Http.Json;

namespace AppFakeStore2.Services
{
    public class LoginService : ILoginService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public LoginService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Constants.ApiDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> AuthenticateAsync(Login login)
        {
            var response = await client.PostAsJsonAsync(Constants.LoginEndpoint, login);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>(options);
                return result.ContainsKey("token") ? result["token"] : null;
            }

            return null;
        }
    }
}
