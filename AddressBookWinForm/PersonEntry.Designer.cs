namespace AddressBookWinForm
{
    partial class PersonEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.AddAddressButton = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.ItemHeight = 25;
            this.addressListBox.Location = new System.Drawing.Point(500, 73);
            this.addressListBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(331, 354);
            this.addressListBox.TabIndex = 0;
            this.addressListBox.TabStop = false;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(143, 73);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(347, 33);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(143, 134);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(347, 33);
            this.lastNameText.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(31, 73);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 25);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(33, 134);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 25);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(143, 202);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(15, 14);
            this.isActive.TabIndex = 3;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(52, 191);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(81, 25);
            this.isActiveLabel.TabIndex = 6;
            this.isActiveLabel.Text = "Is Active";
            // 
            // AddAddressButton
            // 
            this.AddAddressButton.Location = new System.Drawing.Point(344, 191);
            this.AddAddressButton.Name = "AddAddressButton";
            this.AddAddressButton.Size = new System.Drawing.Size(146, 43);
            this.AddAddressButton.TabIndex = 4;
            this.AddAddressButton.Text = "Add Address";
            this.AddAddressButton.UseVisualStyleBackColor = true;
            this.AddAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(716, 435);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(115, 32);
            this.saveRecord.TabIndex = 8;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 508);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.AddAddressButton);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonEntry";
            this.Text = "Address Book ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox addressListBox;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private CheckBox isActive;
        private Label isActiveLabel;
        private Button AddAddressButton;
        private Button saveRecord;
    }
}