﻿using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.TextToSpeech.v1;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static IBM.Watson.TextToSpeech.v1.TextToSpeechService;
using static IBM.Watson.TextToSpeech.v1.TextToSpeechService.GetVoiceEnums;

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
        private const string _prefixKey = "Prefix";
        private const string _trailingKey = "Trailing";

        private string _apikey;
        private string _serviceUrl;
        private string _outputPath;
        private string _fileName;
        private string _voice;
        private List<string> _selectedFiles = new List<string>();

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

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_prefixKey]))
            {
                this.textBoxPrefix.Text = ConfigurationManager.AppSettings[_prefixKey];
            }

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_trailingKey]))
            {
                this.textBoxTrailing.Text = ConfigurationManager.AppSettings[_trailingKey];
            }
            this.cbVoice.Enabled = false;

            this.comboBoxOutput.Items.Add(SynthesizeEnums.AcceptValue.AUDIO_WAV);
            this.comboBoxOutput.Items.Add(SynthesizeEnums.AcceptValue.AUDIO_MP3);
            this.comboBoxOutput.SelectedIndex = 0;
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            this.buttonRequest.Enabled = false;

            IamAuthenticator authenticator = new IamAuthenticator(apikey: _apikey);
            TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
            textToSpeech.SetServiceUrl(_serviceUrl);
            textToSpeech.Client.BaseClient.Timeout = TimeSpan.FromMinutes(60);
            var fileFullName = $"{_outputPath}\\{_fileName}";
            var remainText = this.tbText.Text.EndsWith("\n") ? this.tbText.Text : this.tbText.Text + "\n";
            var remainFullText = $"{this.textBoxPrefix.Text}{remainText}{this.textBoxTrailing.Text}";
            var outputFormat = comboBoxOutput.SelectedItem.ToString();

            var startDatetime = DateTime.Now;
            if (remainFullText.Length < 1000 * 5 - 400)
            {
                var responseMS = textToSpeech.Synthesize(remainFullText, accept: outputFormat, voice: _voice, ratePercentage: -15);

                Console.WriteLine($"The request took {(DateTime.Now - startDatetime).TotalSeconds} secs");
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
                return;
            }

            var runCount = 0;
            var tempFileList = new List<string>();
            do
            {
                runCount++;
                var tempFileName = $"{DateTime.Now.Millisecond}_{runCount.ToString()}";

                tempFileName = outputFormat == SynthesizeEnums.AcceptValue.AUDIO_WAV ? tempFileName + ".wav" : tempFileName + ".mp3";

                var batchAllowedLength = 1000 * 5 - 400 - textBoxPrefix.TextLength - textBoxTrailing.TextLength;
                var tempText = remainText.Substring(0, remainText.Length >= batchAllowedLength ? batchAllowedLength : remainText.Length);
                var lastNewlineIndex = tempText.LastIndexOf("\n");
                var currentbatch = $"{this.textBoxPrefix.Text}{remainText.Substring(0, lastNewlineIndex)}{this.textBoxTrailing.Text}";

                var responseMS = textToSpeech.Synthesize(currentbatch, accept: outputFormat, voice: _voice, ratePercentage: -15);

                using (var ms = responseMS.Result)
                using (FileStream file = new FileStream(tempFileName, FileMode.Create, System.IO.FileAccess.Write))
                {
                    byte[] bytes = new byte[ms.Length];
                    ms.Read(bytes, 0, (int)ms.Length);
                    file.Write(bytes, 0, bytes.Length);
                    ms.Close();
                    tempFileList.Add(file.Name);
                }

                remainText = remainText.Remove(0, lastNewlineIndex);
            }
            while (remainText.Length > 0 && remainText != "\n");


            this.buttonRequest.Enabled = true;
            if (outputFormat == SynthesizeEnums.AcceptValue.AUDIO_WAV)
            {
                Concatenate(fileFullName, tempFileList);

            }
            else
            {
                ConcatenateMp3(fileFullName, tempFileList);
            }

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            foreach (var item in tempFileList)
            {
                if (System.IO.File.Exists(item))
                {
                    System.IO.File.Delete(item);
                }
            }

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

        public static void Concatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                var sampleList = new List<ISampleProvider>();

                foreach (string file in sourceFiles)
                {
                    sampleList.Add(new AudioFileReader(file));
                }

                WaveFileWriter.CreateWaveFile16(outputFile, new ConcatenatingSampleProvider(sampleList));
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }
            System.Windows.Forms.MessageBox.Show("Done", "Message");
        }

        public static void ConcatenateMp3(string outputFile, IEnumerable<string> sourceFiles)
        {
            using (var fileStream = System.IO.File.Create(outputFile))
            {
                foreach (string file in sourceFiles)
                {
                    Mp3FileReader reader = new Mp3FileReader(file);
                    if ((fileStream.Position == 0) && (reader.Id3v2Tag != null))
                    {
                        fileStream.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                    }
                    Mp3Frame frame;
                    while ((frame = reader.ReadNextFrame()) != null)
                    {
                        fileStream.Write(frame.RawData, 0, frame.RawData.Length);
                    }
                }
            }
            System.Windows.Forms.MessageBox.Show("Done", "Message");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_selectedFiles.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Select files first", "Message");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbConcatenateOutputName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Provide an output filename", "Message");
                return;
            }

            if (string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                System.Windows.Forms.MessageBox.Show("Select a folder first", "Message");
                return;
            }

            var outputFilePath = $"{folderBrowserDialog1.SelectedPath}{Path.DirectorySeparatorChar}{tbConcatenateOutputName.Text}";

            if (_selectedFiles.All(f => f.EndsWith(".mp3")))
            {
                ConcatenateMp3(outputFilePath, _selectedFiles);
                return;
            }
            Concatenate(outputFilePath, _selectedFiles);
        }



        private void buttonSelectFiles_Click(object sender, EventArgs e)
        {
            _selectedFiles.Clear();
            this.listBoxSelectedFiles.Items.Clear();
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (string file in openFileDialog1.FileNames)
                {
                    _selectedFiles.Add(file);
                    this.listBoxSelectedFiles.Items.Add(file);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                this.labelConcatOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                return;
            }

            this.labelConcatOutputFolder.Text = "Select a folder first";
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {
            Helper.SaveAppSettings(_prefixKey, textBoxPrefix.Text);
        }

        private void textBoxTrailing_TextChanged(object sender, EventArgs e)
        {
            Helper.SaveAppSettings(_trailingKey, textBoxTrailing.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            labelSelectedFile.Text = openFileDialog2.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelSelectedFile.Text) || string.IsNullOrWhiteSpace(textBoxConvertOutputName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Select a file and set the output name first", "Message");
                return;
            }

            var mp3FilePath = Path.Combine(Path.GetDirectoryName(labelSelectedFile.Text), $"{textBoxConvertOutputName.Text}.mp3");

            using (var stream = new FileStream(labelSelectedFile.Text, FileMode.Open))
            {
                var waveFormat = WaveFormat.CreateMuLawFormat(8000, 1);
                var sample = new RawSourceWaveStream(stream, waveFormat);

                using (var reader = new WaveFileReader(sample))
                {
                    try
                    {
                        MediaFoundationEncoder.EncodeToMp3(reader, mp3FilePath);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            System.Windows.Forms.MessageBox.Show("Done", "Message");
        }
    }
}
