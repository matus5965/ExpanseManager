using ExpenseManager.DataModels;
using ExpenseManager.Forms.Controls;
using Newtonsoft.Json;

namespace ExpenseManager.Utils
{
    public static class JSONUtils
    {
        public static async void ExportAsync(IEnumerable<TransactionControl> transactionControls, Dictionary<int, string> categories)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        await Task.Run(() =>
                        {
                            var settings = new JsonSerializerSettings
                            {
                                Formatting = Formatting.Indented
                            };
                            settings.Converters.Add(new TransactionConverter(categories));

                            string jsonString = JsonConvert.SerializeObject(transactionControls.Select(tc => tc.Transaction), settings);
                            File.WriteAllText(fileName, jsonString);
                        });

                        MessageBox.Show("JSON file exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
    }

    public class TransactionConverter : JsonConverter
    {
        private Dictionary<int, string> categories;
        public TransactionConverter(Dictionary<int, string> categories)
        {
            this.categories = categories;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Transaction);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Transaction t = (Transaction) value;
            writer.WriteStartObject();

            writer.WritePropertyName("Category");
            writer.WriteValue(categories[t.Category]);

            writer.WritePropertyName("Subject");
            writer.WriteValue(t.Subject);

            writer.WritePropertyName("Amount");
            writer.WriteValue(t.Amount * (t.Type == TransactionType.Income ? 1 : -1));

            writer.WritePropertyName("Date");
            writer.WriteValue(t.Date);

            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
