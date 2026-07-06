using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Windows.Forms;

namespace EasyDay_SignUp
{
    public partial class Translation : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;

        public Translation()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private void Translation_Load(object sender, EventArgs e)
        {
            //cmbSourceLanguage.BorderRadius = 20;
            //cmbTargetLanguage.BorderRadius = 20;
            //textInput.BorderRadius = 20;
            //textOutput.BorderRadius = 20;
            cmbSourceLanguage.Items.AddRange(new string[] { "EN", "MS", "ID", "BN", "NE", "VI", "MY" });
            cmbTargetLanguage.Items.AddRange(new string[] { "EN", "MS", "ID", "BN", "NE", "VI", "MY" });
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";
            //MessageBox.Show(url);

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            //MessageBox.Show(responseJson);

            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {
            // Leave empty if you don't need it.
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textInput.Text, cmbSourceLanguage.SelectedItem.ToString().ToLower(), cmbTargetLanguage.SelectedItem.ToString().ToLower());
                textOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex);
                //throw;
            }
        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}
