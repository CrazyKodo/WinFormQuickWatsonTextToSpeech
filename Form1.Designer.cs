namespace WinFormQuickWatsonTextToSpeech
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelApikey = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.tbApikey = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.labelServiceUrl = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.labelOutputFilename = new System.Windows.Forms.Label();
            this.labelOutputfolderPath = new System.Windows.Forms.Label();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.fBDOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetVoiceList = new System.Windows.Forms.Button();
            this.labelVoice = new System.Windows.Forms.Label();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConcatOutputFolder = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbConcatenateOutputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSelectedFiles = new System.Windows.Forms.ListBox();
            this.buttonSelectFiles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.textBoxTrailing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApikey
            // 
            this.labelApikey.AutoSize = true;
            this.labelApikey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApikey.Location = new System.Drawing.Point(50, 27);
            this.labelApikey.Name = "labelApikey";
            this.labelApikey.Size = new System.Drawing.Size(46, 15);
            this.labelApikey.TabIndex = 0;
            this.labelApikey.Text = "Apikey:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(67, 248);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 15);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Text:";
            // 
            // tbApikey
            // 
            this.tbApikey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApikey.Location = new System.Drawing.Point(127, 24);
            this.tbApikey.Name = "tbApikey";
            this.tbApikey.Size = new System.Drawing.Size(653, 23);
            this.tbApikey.TabIndex = 2;
            this.tbApikey.TextChanged += new System.EventHandler(this.tbApikey_TextChanged);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(127, 248);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(1411, 485);
            this.tbText.TabIndex = 3;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.Location = new System.Drawing.Point(70, 788);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 4;
            this.buttonRequest.Text = "SendRequest";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(127, 51);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(653, 23);
            this.tbUrl.TabIndex = 6;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // labelServiceUrl
            // 
            this.labelServiceUrl.AutoSize = true;
            this.labelServiceUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceUrl.Location = new System.Drawing.Point(50, 52);
            this.labelServiceUrl.Name = "labelServiceUrl";
            this.labelServiceUrl.Size = new System.Drawing.Size(62, 15);
            this.labelServiceUrl.TabIndex = 5;
            this.labelServiceUrl.Text = "ServiceUrl:";
            // 
            // tbFilename
            // 
            this.tbFilename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilename.Location = new System.Drawing.Point(153, 144);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(122, 23);
            this.tbFilename.TabIndex = 8;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // labelOutputFilename
            // 
            this.labelOutputFilename.AutoSize = true;
            this.labelOutputFilename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputFilename.Location = new System.Drawing.Point(50, 145);
            this.labelOutputFilename.Name = "labelOutputFilename";
            this.labelOutputFilename.Size = new System.Drawing.Size(97, 15);
            this.labelOutputFilename.TabIndex = 7;
            this.labelOutputFilename.Text = "Output filename:";
            // 
            // labelOutputfolderPath
            // 
            this.labelOutputfolderPath.AutoSize = true;
            this.labelOutputfolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputfolderPath.Location = new System.Drawing.Point(172, 120);
            this.labelOutputfolderPath.Name = "labelOutputfolderPath";
            this.labelOutputfolderPath.Size = new System.Drawing.Size(10, 15);
            this.labelOutputfolderPath.TabIndex = 10;
            this.labelOutputfolderPath.Text = ":";
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFolder.Location = new System.Drawing.Point(53, 116);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(103, 23);
            this.btnOutputFolder.TabIndex = 9;
            this.btnOutputFolder.Text = "Output folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voice:";
            // 
            // buttonGetVoiceList
            // 
            this.buttonGetVoiceList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetVoiceList.Location = new System.Drawing.Point(376, 78);
            this.buttonGetVoiceList.Name = "buttonGetVoiceList";
            this.buttonGetVoiceList.Size = new System.Drawing.Size(115, 23);
            this.buttonGetVoiceList.TabIndex = 12;
            this.buttonGetVoiceList.Text = "Get voice list";
            this.buttonGetVoiceList.UseVisualStyleBackColor = true;
            this.buttonGetVoiceList.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelVoice
            // 
            this.labelVoice.AutoSize = true;
            this.labelVoice.Location = new System.Drawing.Point(125, 85);
            this.labelVoice.Name = "labelVoice";
            this.labelVoice.Size = new System.Drawing.Size(41, 12);
            this.labelVoice.TabIndex = 13;
            this.labelVoice.Text = "label2";
            // 
            // cbVoice
            // 
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(496, 81);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(284, 20);
            this.cbVoice.TabIndex = 21;
            this.cbVoice.SelectedIndexChanged += new System.EventHandler(this.cbVoice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelConcatOutputFolder);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbConcatenateOutputName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxSelectedFiles);
            this.groupBox1.Controls.Add(this.buttonSelectFiles);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(823, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 137);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concatenate wav files";
            // 
            // labelConcatOutputFolder
            // 
            this.labelConcatOutputFolder.AutoSize = true;
            this.labelConcatOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcatOutputFolder.Location = new System.Drawing.Point(505, 26);
            this.labelConcatOutputFolder.Name = "labelConcatOutputFolder";
            this.labelConcatOutputFolder.Size = new System.Drawing.Size(10, 15);
            this.labelConcatOutputFolder.TabIndex = 15;
            this.labelConcatOutputFolder.Text = ":";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Output folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbConcatenateOutputName
            // 
            this.tbConcatenateOutputName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConcatenateOutputName.Location = new System.Drawing.Point(268, 23);
            this.tbConcatenateOutputName.Name = "tbConcatenateOutputName";
            this.tbConcatenateOutputName.Size = new System.Drawing.Size(122, 23);
            this.tbConcatenateOutputName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output filename:";
            // 
            // listBoxSelectedFiles
            // 
            this.listBoxSelectedFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxSelectedFiles.FormattingEnabled = true;
            this.listBoxSelectedFiles.ItemHeight = 15;
            this.listBoxSelectedFiles.Location = new System.Drawing.Point(3, 55);
            this.listBoxSelectedFiles.Name = "listBoxSelectedFiles";
            this.listBoxSelectedFiles.Size = new System.Drawing.Size(709, 79);
            this.listBoxSelectedFiles.TabIndex = 11;
            // 
            // buttonSelectFiles
            // 
            this.buttonSelectFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFiles.Location = new System.Drawing.Point(7, 22);
            this.buttonSelectFiles.Name = "buttonSelectFiles";
            this.buttonSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFiles.TabIndex = 10;
            this.buttonSelectFiles.Text = "Select files";
            this.buttonSelectFiles.UseVisualStyleBackColor = true;
            this.buttonSelectFiles.Click += new System.EventHandler(this.buttonSelectFiles_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|Wav Files Only (*.wav)|*.wav";
            this.openFileDialog1.Multiselect = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prefix:";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrefix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrefix.Location = new System.Drawing.Point(127, 187);
            this.textBoxPrefix.Multiline = true;
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrefix.Size = new System.Drawing.Size(1408, 43);
            this.textBoxPrefix.TabIndex = 24;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            // 
            // textBoxTrailing
            // 
            this.textBoxTrailing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrailing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrailing.Location = new System.Drawing.Point(130, 739);
            this.textBoxTrailing.Multiline = true;
            this.textBoxTrailing.Name = "textBoxTrailing";
            this.textBoxTrailing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrailing.Size = new System.Drawing.Size(1408, 43);
            this.textBoxTrailing.TabIndex = 26;
            this.textBoxTrailing.TextChanged += new System.EventHandler(this.textBoxTrailing_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 742);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Trailing:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Output type:";
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Location = new System.Drawing.Point(403, 144);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(284, 23);
            this.comboBoxOutput.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 825);
            this.Controls.Add(this.comboBoxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTrailing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbVoice);
            this.Controls.Add(this.labelVoice);
            this.Controls.Add(this.buttonGetVoiceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutputfolderPath);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.labelOutputFilename);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.labelServiceUrl);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbApikey);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelApikey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApikey;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox tbApikey;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label labelServiceUrl;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Label labelOutputFilename;
        private System.Windows.Forms.Label labelOutputfolderPath;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog fBDOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetVoiceList;
        private System.Windows.Forms.Label labelVoice;
        private System.Windows.Forms.ComboBox cbVoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxSelectedFiles;
        private System.Windows.Forms.TextBox tbConcatenateOutputName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConcatOutputFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.TextBox textBoxTrailing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOutput;
    }
}

