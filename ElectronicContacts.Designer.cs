namespace customerContacts
{
    partial class ElectronicContacts
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTB = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ContactID_TB = new System.Windows.Forms.TextBox();
            this.ContactID_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(41, 279);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTB.Location = new System.Drawing.Point(132, 276);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(226, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNameTB.Location = new System.Drawing.Point(132, 307);
            this.LastNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(226, 20);
            this.LastNameTB.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(41, 310);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(65, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name *";
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailTB.Location = new System.Drawing.Point(132, 340);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(226, 20);
            this.EmailTB.TabIndex = 5;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(41, 344);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email *";
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberTB.Location = new System.Drawing.Point(132, 373);
            this.PhoneNumberTB.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(226, 20);
            this.PhoneNumberTB.TabIndex = 7;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(41, 376);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number *";
            // 
            // GenderCB
            // 
            this.GenderCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCB.Location = new System.Drawing.Point(132, 465);
            this.GenderCB.Margin = new System.Windows.Forms.Padding(2);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(226, 21);
            this.GenderCB.TabIndex = 8;
            // 
            // GenderLabel
            // 
            this.GenderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(41, 469);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(49, 13);
            this.GenderLabel.TabIndex = 9;
            this.GenderLabel.Text = "Gender *";
            // 
            // AddressTB
            // 
            this.AddressTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddressTB.Location = new System.Drawing.Point(132, 402);
            this.AddressTB.Margin = new System.Windows.Forms.Padding(2);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(226, 53);
            this.AddressTB.TabIndex = 11;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(41, 405);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Location = new System.Drawing.Point(44, 515);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 41);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Submit";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Location = new System.Drawing.Point(226, 515);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(55, 41);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateButton.Location = new System.Drawing.Point(152, 515);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(55, 41);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(301, 515);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(55, 41);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dbGridView
            // 
            this.dbGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.Location = new System.Drawing.Point(429, 279);
            this.dbGridView.Margin = new System.Windows.Forms.Padding(50, 52, 50, 52);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            this.dbGridView.RowHeadersWidth = 82;
            this.dbGridView.RowTemplate.Height = 33;
            this.dbGridView.Size = new System.Drawing.Size(332, 277);
            this.dbGridView.TabIndex = 17;
            this.dbGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_RowHeaderMouseClick);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(426, 249);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 18;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(471, 246);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.MaximumSize = new System.Drawing.Size(340, 20);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(290, 20);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ContactID_TB
            // 
            this.ContactID_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactID_TB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ContactID_TB.Enabled = false;
            this.ContactID_TB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ContactID_TB.Location = new System.Drawing.Point(132, 243);
            this.ContactID_TB.Margin = new System.Windows.Forms.Padding(2);
            this.ContactID_TB.Name = "ContactID_TB";
            this.ContactID_TB.ReadOnly = true;
            this.ContactID_TB.Size = new System.Drawing.Size(226, 20);
            this.ContactID_TB.TabIndex = 21;
            // 
            // ContactID_Label
            // 
            this.ContactID_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContactID_Label.AutoSize = true;
            this.ContactID_Label.Location = new System.Drawing.Point(41, 246);
            this.ContactID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactID_Label.Name = "ContactID_Label";
            this.ContactID_Label.Size = new System.Drawing.Size(58, 13);
            this.ContactID_Label.TabIndex = 20;
            this.ContactID_Label.Text = "Contact ID";
            // 
            // ElectronicContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(782, 597);
            this.Controls.Add(this.ContactID_TB);
            this.Controls.Add(this.ContactID_Label);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.PhoneNumberTB);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.FirstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElectronicContacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ElectronicContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PhoneNumberTB;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox ContactID_TB;
        private System.Windows.Forms.Label ContactID_Label;
    }
}

