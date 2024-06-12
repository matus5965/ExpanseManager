using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Utils
{
    public class CurrencyUtils
    {
        public static async void GetCurrenciesAsync()
        {
            string url = "http://localhost:3005/v1/exchange-rates/latest?access_key=qky7aRBEjytfWC2x";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        JObject jsonObject = JObject.Parse(json);

                        JObject ratesObject = (JObject)jsonObject["rates"];

                        foreach (var rate in ratesObject)
                        {
                            string currency = rate.Key;
                            double exchangeRate = (double)rate.Value;

                            MessageBox.Show($"{currency}: {exchangeRate}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to fetch data from {url}. Status code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
