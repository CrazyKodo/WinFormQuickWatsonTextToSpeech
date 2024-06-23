using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Cloud.SDK.Core.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Watson.TextToSpeech.v1;
using static IBM.Watson.TextToSpeech.v1.TextToSpeechService.GetVoiceEnums;
using System.IO;
using IBM.Watson.TextToSpeech.v1.Model;

namespace WinFormQuickWatsonTextToSpeech
{
    public partial class Form1 : Form
    {
        private const string _apikeySettingKey = "ApiKey";
        private const string _serviceUrlSettingKey = "ServiceUrl";
        private const string _outputPathSettingKey = "OutputPath";
        private const string _fileNameSettingKey = "Filename";
        private const string _textSettingKey = "Text";
        private const string _voiceSettingKey = "Voice";

        private string _apikey;
        private string _serviceUrl;
        private string _outputPath;
        private string _fileName;
        private string _voice;
        public Form1()
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_apikeySettingKey]))
            {
                _apikey = ConfigurationManager.AppSettings[_apikeySettingKey];
                this.tbApikey.Text = _apikey;
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_serviceUrlSettingKey]))
            {
                _serviceUrl = ConfigurationManager.AppSettings[_serviceUrlSettingKey];
                this.tbUrl.Text = _serviceUrl;
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_outputPathSettingKey]))
            {
                _outputPath = ConfigurationManager.AppSettings[_outputPathSettingKey];
                this.labelOutputfolderPath.Text = $": {_outputPath}";
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_fileNameSettingKey]))
            {
                _fileName = ConfigurationManager.AppSettings[_fileNameSettingKey];
                this.tbFilename.Text = _fileName;
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_textSettingKey]))
            {
                this.tbText.Text = ConfigurationManager.AppSettings[_textSettingKey];
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_voiceSettingKey]))
            {
                _voice = ConfigurationManager.AppSettings[_voiceSettingKey];
                this.labelVoice.Text = _voice;
            }
            else
            {
                _voice = VoiceValue.EN_US_EMMAEXPRESSIVE;
            }

            this.cbVoice.Enabled = false;
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            this.buttonRequest.Enabled = false;

            IamAuthenticator authenticator = new IamAuthenticator(apikey: _apikey);
            TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
            textToSpeech.SetServiceUrl(_serviceUrl);
            var text = this.tbText.Text;
            textToSpeech.Client.BaseClient.Timeout = TimeSpan.FromMinutes(10);

            var responseMS = textToSpeech.Synthesize(text,voice: _voice, ratePercentage: -15);

            var fileFullName = $"{_outputPath}\\{_fileName}";
            using (var ms = responseMS.Result)
            using (FileStream file = new FileStream(fileFullName, FileMode.Create, System.IO.FileAccess.Write))
            {
                byte[] bytes = new byte[ms.Length];
                ms.Read(bytes, 0, (int)ms.Length);
                file.Write(bytes, 0, bytes.Length);
                ms.Close();
            }
            this.buttonRequest.Enabled = true;
            System.Windows.Forms.MessageBox.Show("Done", "Message");
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fBDOutput.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fBDOutput.SelectedPath))
            {
                this.labelOutputfolderPath.Text = $": {fBDOutput.SelectedPath}";
                _outputPath = fBDOutput.SelectedPath;

                Helper.SaveAppSettings(_outputPathSettingKey, _outputPath);
                return;
            }

            this.labelOutputfolderPath.Text = "Select a folder first";
            _outputPath = string.Empty;
        }

        private void tbApikey_TextChanged(object sender, EventArgs e)
        {
            _apikey = tbApikey.Text;
            Helper.SaveAppSettings(_apikeySettingKey, _apikey);
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            _serviceUrl = tbUrl.Text;
            Helper.SaveAppSettings(_serviceUrlSettingKey, _serviceUrl);
        }

        private void tbFilename_TextChanged(object sender, EventArgs e)
        {
            _fileName = tbFilename.Text;
            Helper.SaveAppSettings(_fileNameSettingKey, _fileName);
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            Helper.SaveAppSettings(_textSettingKey, tbText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IamAuthenticator authenticator = new IamAuthenticator(apikey: _apikey);
            TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
            textToSpeech.SetServiceUrl(_serviceUrl); 
            var result = textToSpeech.ListVoices();
            var voiceList = result.Result;
            var voices = voiceList._Voices.Select(v => v.Name).ToArray();
            cbVoice.Enabled = true;
            cbVoice.DataSource = voices;
            cbVoice.SelectedIndex = Array.FindIndex(voices, x => x == _voice);

        }

        private void cbVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _voice = cbVoice.SelectedValue.ToString();
            this.labelVoice.Text = _voice;
            Helper.SaveAppSettings(_voiceSettingKey, _voice);
        }
    }
}
