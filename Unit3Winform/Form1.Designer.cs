namespace Unit2Winform
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInitDBConn
            // 
            this.buttonInitDBConn.Location = new System.Drawing.Point(35, 35);
            this.buttonInitDBConn.Name = "buttonInitDBConn";
            this.buttonInitDBConn.Size = new System.Drawing.Size(154, 23);
            this.buttonInitDBConn.TabIndex = 0;
            this.buttonInitDBConn.Text = "Initialize DB Connection";
            this.buttonInitDBConn.UseVisualStyleBackColor = true;
            this.buttonInitDBConn.Click += new System.EventHandler(this.buttonInitDBConn_Click);
            // 
            // buttonCNumber
            // 
            this.buttonCNumber.Location = new System.Drawing.Point(35, 76);
            this.buttonCNumber.Name = "buttonCNumber";
            this.buttonCNumber.Size = new System.Drawing.Size(154, 23);
            this.buttonCNumber.TabIndex = 1;
            this.buttonCNumber.Text = "Customer Number";
            this.buttonCNumber.UseVisualStyleBackColor = true;
            this.buttonCNumber.Click += new System.EventHandler(this.buttonCNumber_Click);
            // 
            // buttonCName
            // 
            this.buttonCName.Location = new System.Drawing.Point(35, 117);
            this.buttonCName.Name = "buttonCName";
            this.buttonCName.Size = new System.Drawing.Size(154, 23);
            this.buttonCName.TabIndex = 2;
            this.buttonCName.Text = "Customer Name";
            this.buttonCName.UseVisualStyleBackColor = true;
            this.buttonCName.Click += new System.EventHandler(this.buttonCName_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 9);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 195);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCName);
            this.Controls.Add(this.buttonCNumber);
            this.Controls.Add(this.buttonInitDBConn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInitDBConn;
        private System.Windows.Forms.Button buttonCNumber;
        private System.Windows.Forms.Button buttonCName;
        private System.Windows.Forms.Button button2;
    }
}

