using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TokenDeneme1.Shared
{
    public static class RestHelper
    {
        public static string BeautifyJson(string jsonStr) //Gelen dataya JSON formatına çeviriyoruz.
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }


        private static readonly string baseURL = "https://reqres.in/api/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
            {
                using (HttpContent content = res.Content)
                {
                    string data = await content.ReadAsStringAsync();
                    if (data != null)
                    {
                        return data;
                    }
                }
            }
            return string.Empty;
        }
        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
            {
                using (HttpContent content = res.Content)
                {
                    string data = await content.ReadAsStringAsync();
                    if (data != null)
                    {
                        return data;
                    }
                }
            }
            return string.Empty;
        }
        public static async Task<string> Post(string name, string job) //Add
        {
            var inputData = new Dictionary<string, string>
            {
                {"name", name },
                {"job",job }
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
                return string.Empty;
            }
        }
        public static async Task<string> Put(string id, string name, string job) //Update
        {
            var inputData = new Dictionary<string, string>
            {
                {"name", name},
                {"job", job }
            };
            var input = new FormUrlEncodedContent(inputData);
            using(HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input))
                {
                    using(HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }
                    
                }
                return string.Empty;
            }
        }
        public static async Task<string> Delete (string id)
        {
            using(HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://reqres.in/api/users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        System.Windows.Forms.MessageBox.Show(res.StatusCode.ToString() + "- Silindi");
                        string data = await content.ReadAsStringAsync();    
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

    }
    }

