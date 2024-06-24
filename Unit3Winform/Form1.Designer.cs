namespace Unit3Winform
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
            this.buttonInitDBConn = new System.Windows.Forms.Button();
            this.buttonCNumber = new System.Windows.Forms.Button();
            this.buttonCName = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelServerName = new System.Windows.Forms.Label();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEName = new System.Windows.Forms.Button();
            this.buttonECount = new System.Windows.Forms.Button();
            this.buttonOCount = new System.Windows.Forms.Button();
            this.buttonSName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInitDBConn
            // 
            this.buttonInitDBConn.Location = new System.Drawing.Point(60, 182);
            this.buttonInitDBConn.Name = "buttonInitDBConn";
            this.buttonInitDBConn.Size = new System.Drawing.Size(154, 23);
            this.buttonInitDBConn.TabIndex = 5;
            this.buttonInitDBConn.Text = "Initialize DB Connection";
            this.buttonInitDBConn.UseVisualStyleBackColor = true;
            this.buttonInitDBConn.Click += new System.EventHandler(this.buttonInitDBConn_Click);
            // 
            // buttonCNumber
            // 
            this.buttonCNumber.Location = new System.Drawing.Point(60, 222);
            this.buttonCNumber.Name = "buttonCNumber";
            this.buttonCNumber.Size = new System.Drawing.Size(154, 23);
            this.buttonCNumber.TabIndex = 6;
            this.buttonCNumber.Text = "Customer Number";
            this.buttonCNumber.UseVisualStyleBackColor = true;
            this.buttonCNumber.Click += new System.EventHandler(this.buttonCNumber_Click);
            // 
            // buttonCName
            // 
            this.buttonCName.Location = new System.Drawing.Point(60, 262);
            this.buttonCName.Name = "buttonCName";
            this.buttonCName.Size = new System.Drawing.Size(154, 23);
            this.buttonCName.TabIndex = 7;
            this.buttonCName.Text = "Customer Name";
            this.buttonCName.UseVisualStyleBackColor = true;
            this.buttonCName.Click += new System.EventHandler(this.buttonCName_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(38, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(40, 63);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(24, 96);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(72, 13);
            this.labelServerName.TabIndex = 6;
            this.labelServerName.Text = "Server Name:";
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.AutoSize = true;
            this.labelDatabaseName.Location = new System.Drawing.Point(9, 129);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(87, 13);
            this.labelDatabaseName.TabIndex = 7;
            this.labelDatabaseName.Text = "Database Name:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(99, 30);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(115, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "user_ceo";
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.Location = new System.Drawing.Point(99, 129);
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(115, 20);
            this.textBoxDatabaseName.TabIndex = 4;
            this.textBoxDatabaseName.Text = "NorthWind";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(99, 96);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(115, 20);
            this.textBoxServerName.TabIndex = 3;
            this.textBoxServerName.Text = "callee01\\sqlexpress";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(99, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(115, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "testing";
            // 
            // buttonEName
            // 
            this.buttonEName.Location = new System.Drawing.Point(60, 342);
            this.buttonEName.Name = "buttonEName";
            this.buttonEName.Size = new System.Drawing.Size(154, 23);
            this.buttonEName.TabIndex = 8;
            this.buttonEName.Text = "Employee Name";
            this.buttonEName.UseVisualStyleBackColor = true;
            this.buttonEName.Click += new System.EventHandler(this.buttonEName_Click);
            // 
            // buttonECount
            // 
            this.buttonECount.Location = new System.Drawing.Point(60, 302);
            this.buttonECount.Name = "buttonECount";
            this.buttonECount.Size = new System.Drawing.Size(154, 23);
            this.buttonECount.TabIndex = 9;
            this.buttonECount.Text = "Employee Count";
            this.buttonECount.UseVisualStyleBackColor = true;
            this.buttonECount.Click += new System.EventHandler(this.buttonECount_Click);
            // 
            // buttonOCount
            // 
            this.buttonOCount.Location = new System.Drawing.Point(60, 382);
            this.buttonOCount.Name = "buttonOCount";
            this.buttonOCount.Size = new System.Drawing.Size(154, 23);
            this.buttonOCount.TabIndex = 10;
            this.buttonOCount.Text = "Order Count";
            this.buttonOCount.UseVisualStyleBackColor = true;
            this.buttonOCount.Click += new System.EventHandler(this.buttonOCount_Click);
            // 
            // buttonSName
            // 
            this.buttonSName.Location = new System.Drawing.Point(60, 422);
            this.buttonSName.Name = "buttonSName";
            this.buttonSName.Size = new System.Drawing.Size(154, 23);
            this.buttonSName.TabIndex = 11;
            this.buttonSName.Text = "Ship Name";
            this.buttonSName.UseVisualStyleBackColor = true;
            this.buttonSName.Click += new System.EventHandler(this.buttonSName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 480);
            this.Controls.Add(this.buttonSName);
            this.Controls.Add(this.buttonOCount);
            this.Controls.Add(this.buttonECount);
            this.Controls.Add(this.buttonEName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.textBoxDatabaseName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelDatabaseName);
            this.Controls.Add(this.labelServerName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonCName);
            this.Controls.Add(this.buttonCNumber);
            this.Controls.Add(this.buttonInitDBConn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitDBConn;
        private System.Windows.Forms.Button buttonCNumber;
        private System.Windows.Forms.Button buttonCName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEName;
        private System.Windows.Forms.Button buttonECount;
        private System.Windows.Forms.Button buttonOCount;
        private System.Windows.Forms.Button buttonSName;
    }
}

