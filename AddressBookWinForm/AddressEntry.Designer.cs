namespace AddressBookWinForm
{
    partial class AddressEntry
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.postCodeLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.postcodeText = new System.Windows.Forms.TextBox();
            this.countyText = new System.Windows.Forms.TextBox();
            this.addressFormTitle = new System.Windows.Forms.Label();
            this.saveAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(207, 157);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(44, 25);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(119, 96);
            this.streetAddressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(132, 25);
            this.streetAddressLabel.TabIndex = 7;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(261, 154);
            this.cityText.Margin = new System.Windows.Forms.Padding(5);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(347, 33);
            this.cityText.TabIndex = 2;
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(261, 93);
            this.streetAddressText.Margin = new System.Windows.Forms.Padding(5);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(347, 33);
            this.streetAddressText.TabIndex = 1;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Location = new System.Drawing.Point(155, 270);
            this.postCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(96, 25);
            this.postCodeLabel.TabIndex = 12;
            this.postCodeLabel.Text = "Post Code";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(179, 212);
            this.countyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(72, 25);
            this.countyLabel.TabIndex = 11;
            this.countyLabel.Text = "County";
            // 
            // postcodeText
            // 
            this.postcodeText.Location = new System.Drawing.Point(261, 270);
            this.postcodeText.Margin = new System.Windows.Forms.Padding(5);
            this.postcodeText.Name = "postcodeText";
            this.postcodeText.Size = new System.Drawing.Size(347, 33);
            this.postcodeText.TabIndex = 4;
            // 
            // countyText
            // 
            this.countyText.Location = new System.Drawing.Point(261, 209);
            this.countyText.Margin = new System.Windows.Forms.Padding(5);
            this.countyText.Name = "countyText";
            this.countyText.Size = new System.Drawing.Size(347, 33);
            this.countyText.TabIndex = 3;
            // 
            // addressFormTitle
            // 
            this.addressFormTitle.AutoSize = true;
            this.addressFormTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressFormTitle.Location = new System.Drawing.Point(261, 25);
            this.addressFormTitle.Name = "addressFormTitle";
            this.addressFormTitle.Size = new System.Drawing.Size(192, 40);
            this.addressFormTitle.TabIndex = 13;
            this.addressFormTitle.Text = "Address Entry";
            // 
            // saveAddress
            // 
            this.saveAddress.Location = new System.Drawing.Point(261, 332);
            this.saveAddress.Name = "saveAddress";
            this.saveAddress.Size = new System.Drawing.Size(192, 35);
            this.saveAddress.TabIndex = 14;
            this.saveAddress.Text = "Submit";
            this.saveAddress.UseVisualStyleBackColor = true;
            this.saveAddress.Click += new System.EventHandler(this.saveAddress_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 416);
            this.Controls.Add(this.saveAddress);
            this.Controls.Add(this.addressFormTitle);
            this.Controls.Add(this.postCodeLabel);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.postcodeText);
            this.Controls.Add(this.countyText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.streetAddressText);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddressEntry";
            this.Text = "Address Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cityLabel;
        private Label streetAddressLabel;
        private TextBox cityText;
        private TextBox streetAddressText;
        private Label postCodeLabel;
        private Label countyLabel;
        private TextBox postcodeText;
        private TextBox countyText;
        private Label addressFormTitle;
        private Button saveAddress;
    }
}