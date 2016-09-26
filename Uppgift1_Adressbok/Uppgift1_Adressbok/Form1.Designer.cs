namespace Uppgift1_Adressbok
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
            this.ListBoxAddressbook = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.TextZip = new System.Windows.Forms.TextBox();
            this.TextCity = new System.Windows.Forms.TextBox();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelZip = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonClearSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxAddressbook
            // 
            this.ListBoxAddressbook.BackColor = System.Drawing.Color.Ivory;
            this.ListBoxAddressbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxAddressbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAddressbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxAddressbook.FormattingEnabled = true;
            this.ListBoxAddressbook.HorizontalScrollbar = true;
            this.ListBoxAddressbook.ItemHeight = 20;
            this.ListBoxAddressbook.Location = new System.Drawing.Point(28, 86);
            this.ListBoxAddressbook.Name = "ListBoxAddressbook";
            this.ListBoxAddressbook.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxAddressbook.Size = new System.Drawing.Size(402, 282);
            this.ListBoxAddressbook.Sorted = true;
            this.ListBoxAddressbook.TabIndex = 15;
            this.ListBoxAddressbook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAddressbook_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADRESSBOK";
            // 
            // LabelMessage
            // 
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelMessage.Location = new System.Drawing.Point(470, 302);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(230, 96);
            this.LabelMessage.TabIndex = 18;
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.Ivory;
            this.TextName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(593, 50);
            this.TextName.Multiline = true;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(254, 28);
            this.TextName.TabIndex = 1;
            this.TextName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextName_KeyDown);
            // 
            // TextAddress
            // 
            this.TextAddress.BackColor = System.Drawing.Color.Ivory;
            this.TextAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddress.Location = new System.Drawing.Point(593, 91);
            this.TextAddress.Multiline = true;
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(254, 28);
            this.TextAddress.TabIndex = 3;
            this.TextAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextAddress_KeyDown);
            // 
            // TextZip
            // 
            this.TextZip.BackColor = System.Drawing.Color.Ivory;
            this.TextZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextZip.Location = new System.Drawing.Point(593, 132);
            this.TextZip.Multiline = true;
            this.TextZip.Name = "TextZip";
            this.TextZip.Size = new System.Drawing.Size(254, 28);
            this.TextZip.TabIndex = 5;
            this.TextZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextZip_KeyPress);
            // 
            // TextCity
            // 
            this.TextCity.BackColor = System.Drawing.Color.Ivory;
            this.TextCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCity.Location = new System.Drawing.Point(593, 173);
            this.TextCity.Multiline = true;
            this.TextCity.Name = "TextCity";
            this.TextCity.Size = new System.Drawing.Size(254, 28);
            this.TextCity.TabIndex = 7;
            this.TextCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCity_KeyDown);
            // 
            // TextPhone
            // 
            this.TextPhone.BackColor = System.Drawing.Color.Ivory;
            this.TextPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPhone.Location = new System.Drawing.Point(593, 214);
            this.TextPhone.Multiline = true;
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(254, 28);
            this.TextPhone.TabIndex = 9;
            this.TextPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPhone_KeyPress);
            // 
            // TextEmail
            // 
            this.TextEmail.BackColor = System.Drawing.Color.Ivory;
            this.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.Location = new System.Drawing.Point(593, 255);
            this.TextEmail.Multiline = true;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(254, 28);
            this.TextEmail.TabIndex = 11;
            this.TextEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEmail_KeyDown);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Black;
            this.LabelName.Location = new System.Drawing.Point(463, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(52, 18);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Namn";
            this.LabelName.UseWaitCursor = true;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.ForeColor = System.Drawing.Color.Black;
            this.LabelAddress.Location = new System.Drawing.Point(463, 96);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(95, 18);
            this.LabelAddress.TabIndex = 2;
            this.LabelAddress.Text = "Gatuadress";
            // 
            // LabelZip
            // 
            this.LabelZip.AutoSize = true;
            this.LabelZip.BackColor = System.Drawing.Color.Transparent;
            this.LabelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelZip.ForeColor = System.Drawing.Color.Black;
            this.LabelZip.Location = new System.Drawing.Point(463, 137);
            this.LabelZip.Name = "LabelZip";
            this.LabelZip.Size = new System.Drawing.Size(104, 18);
            this.LabelZip.TabIndex = 4;
            this.LabelZip.Text = "Postnummer";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCity.ForeColor = System.Drawing.Color.Black;
            this.LabelCity.Location = new System.Drawing.Point(463, 178);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(64, 18);
            this.LabelCity.TabIndex = 6;
            this.LabelCity.Text = "Postort";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.ForeColor = System.Drawing.Color.Black;
            this.LabelPhone.Location = new System.Drawing.Point(463, 219);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(64, 18);
            this.LabelPhone.TabIndex = 8;
            this.LabelPhone.Text = "Telefon";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.Black;
            this.LabelEmail.Location = new System.Drawing.Point(463, 260);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(50, 18);
            this.LabelEmail.TabIndex = 10;
            this.LabelEmail.Text = "Email";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonSave.Location = new System.Drawing.Point(720, 302);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(127, 53);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Spara";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.Black;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(335, 50);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(95, 28);
            this.ButtonSearch.TabIndex = 14;
            this.ButtonSearch.Text = "Sök";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Brown;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(325, 373);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(104, 28);
            this.ButtonDelete.TabIndex = 17;
            this.ButtonDelete.Text = "Ta bort";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click_1);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.Ivory;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(28, 50);
            this.TextBoxSearch.Multiline = true;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(308, 28);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Black;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Location = new System.Drawing.Point(720, 364);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(127, 34);
            this.ButtonClose.TabIndex = 20;
            this.ButtonClose.Text = "Avsluta";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Redigera";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonClearSelected
            // 
            this.ButtonClearSelected.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClearSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearSelected.ForeColor = System.Drawing.Color.Black;
            this.ButtonClearSelected.Location = new System.Drawing.Point(28, 364);
            this.ButtonClearSelected.Name = "ButtonClearSelected";
            this.ButtonClearSelected.Size = new System.Drawing.Size(87, 52);
            this.ButtonClearSelected.TabIndex = 21;
            this.ButtonClearSelected.Text = "Ta bort val";
            this.ButtonClearSelected.UseVisualStyleBackColor = false;
            this.ButtonClearSelected.Click += new System.EventHandler(this.ButtonClearSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Uppgift1_Adressbok.Properties.Resources.imgres1;
            this.ClientSize = new System.Drawing.Size(875, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ListBoxAddressbook);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelZip);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextPhone);
            this.Controls.Add(this.TextCity);
            this.Controls.Add(this.TextZip);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.ButtonClearSelected);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxAddressbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.TextBox TextZip;
        private System.Windows.Forms.TextBox TextCity;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelZip;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonClearSelected;
    }
}

