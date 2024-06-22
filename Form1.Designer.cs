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
            this.SuspendLayout();
            // 
            // labelApikey
            // 
            this.labelApikey.AutoSize = true;
            this.labelApikey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApikey.Location = new System.Drawing.Point(68, 51);
            this.labelApikey.Name = "labelApikey";
            this.labelApikey.Size = new System.Drawing.Size(46, 15);
            this.labelApikey.TabIndex = 0;
            this.labelApikey.Text = "Apikey:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(68, 180);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 15);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Text:";
            // 
            // tbApikey
            // 
            this.tbApikey.Location = new System.Drawing.Point(145, 48);
            this.tbApikey.Name = "tbApikey";
            this.tbApikey.Size = new System.Drawing.Size(512, 21);
            this.tbApikey.TabIndex = 2;
            this.tbApikey.TextChanged += new System.EventHandler(this.tbApikey_TextChanged);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(127, 180);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(661, 216);
            this.tbText.TabIndex = 3;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.Location = new System.Drawing.Point(70, 413);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 4;
            this.buttonRequest.Text = "SendRequest";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(145, 75);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(512, 21);
            this.tbUrl.TabIndex = 6;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // labelServiceUrl
            // 
            this.labelServiceUrl.AutoSize = true;
            this.labelServiceUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceUrl.Location = new System.Drawing.Point(68, 78);
            this.labelServiceUrl.Name = "labelServiceUrl";
            this.labelServiceUrl.Size = new System.Drawing.Size(62, 15);
            this.labelServiceUrl.TabIndex = 5;
            this.labelServiceUrl.Text = "ServiceUrl:";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(175, 139);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(122, 21);
            this.tbFilename.TabIndex = 8;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // labelOutputFilename
            // 
            this.labelOutputFilename.AutoSize = true;
            this.labelOutputFilename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputFilename.Location = new System.Drawing.Point(68, 142);
            this.labelOutputFilename.Name = "labelOutputFilename";
            this.labelOutputFilename.Size = new System.Drawing.Size(97, 15);
            this.labelOutputFilename.TabIndex = 7;
            this.labelOutputFilename.Text = "Output filename:";
            // 
            // labelOutputfolderPath
            // 
            this.labelOutputfolderPath.AutoSize = true;
            this.labelOutputfolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputfolderPath.Location = new System.Drawing.Point(179, 106);
            this.labelOutputfolderPath.Name = "labelOutputfolderPath";
            this.labelOutputfolderPath.Size = new System.Drawing.Size(10, 15);
            this.labelOutputfolderPath.TabIndex = 10;
            this.labelOutputfolderPath.Text = ":";
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputFolder.Location = new System.Drawing.Point(70, 102);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(103, 23);
            this.btnOutputFolder.TabIndex = 9;
            this.btnOutputFolder.Text = "Output folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

