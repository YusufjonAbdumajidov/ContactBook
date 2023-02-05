namespace Contact_book
{
    partial class ContactBook
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
            this.newButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.telText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.contactsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsData)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newButton.Location = new System.Drawing.Point(670, 11);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(119, 44);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(172, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(453, 22);
            this.nameText.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loadButton.Location = new System.Drawing.Point(670, 61);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(119, 39);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "EDIT";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveButton.Location = new System.Drawing.Point(669, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 37);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(670, 149);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 37);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of birth:";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(172, 53);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(453, 22);
            this.surnameText.TabIndex = 10;
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(172, 91);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(453, 22);
            this.telText.TabIndex = 11;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(172, 129);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(453, 22);
            this.emailText.TabIndex = 12;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(172, 167);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(453, 22);
            this.dateText.TabIndex = 13;
            // 
            // contactsData
            // 
            this.contactsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsData.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.contactsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsData.Location = new System.Drawing.Point(12, 213);
            this.contactsData.Name = "contactsData";
            this.contactsData.RowHeadersWidth = 51;
            this.contactsData.RowTemplate.Height = 24;
            this.contactsData.Size = new System.Drawing.Size(782, 225);
            this.contactsData.TabIndex = 14;
            this.contactsData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsData_CellDoubleClick);
            // 
            // ContactBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsData);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newButton);
            this.Name = "ContactBook";
            this.Text = "ContactBook";
            this.Load += new System.EventHandler(this.ContactBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.DataGridView contactsData;
    }
}

