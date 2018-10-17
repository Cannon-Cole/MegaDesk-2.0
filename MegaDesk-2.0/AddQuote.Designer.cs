namespace MegaDesk_4_ColeCannon
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.AddNewQuoteAcceptBtn = new System.Windows.Forms.Button();
            this.CancelQuoteBtn = new System.Windows.Forms.Button();
            this.HeightTitle = new System.Windows.Forms.Label();
            this.WidthTitle = new System.Windows.Forms.Label();
            this.HeightInputErrorLabel = new System.Windows.Forms.Label();
            this.WidthInputErrorLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RushCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuoteAdded = new System.Windows.Forms.Label();
            this.NotificationTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTitle = new System.Windows.Forms.Label();
            this.DrawerCombo = new System.Windows.Forms.ComboBox();
            this.DrawerErrorLabel = new System.Windows.Forms.Label();
            this.MaterialErrorLabel = new System.Windows.Forms.Label();
            this.RushErrorLabel = new System.Windows.Forms.Label();
            this.CustomerNameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewQuoteAcceptBtn
            // 
            this.AddNewQuoteAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteAcceptBtn.Location = new System.Drawing.Point(437, 326);
            this.AddNewQuoteAcceptBtn.Name = "AddNewQuoteAcceptBtn";
            this.AddNewQuoteAcceptBtn.Size = new System.Drawing.Size(195, 65);
            this.AddNewQuoteAcceptBtn.TabIndex = 7;
            this.AddNewQuoteAcceptBtn.Text = "&Add New Quote";
            this.AddNewQuoteAcceptBtn.UseVisualStyleBackColor = true;
            this.AddNewQuoteAcceptBtn.Click += new System.EventHandler(this.AddNewQuoteAccept_Click);
            // 
            // CancelQuoteBtn
            // 
            this.CancelQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelQuoteBtn.Location = new System.Drawing.Point(192, 333);
            this.CancelQuoteBtn.Name = "CancelQuoteBtn";
            this.CancelQuoteBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CancelQuoteBtn.Size = new System.Drawing.Size(195, 50);
            this.CancelQuoteBtn.TabIndex = 8;
            this.CancelQuoteBtn.Text = "&Cancel";
            this.CancelQuoteBtn.UseVisualStyleBackColor = true;
            this.CancelQuoteBtn.Click += new System.EventHandler(this.CancelQuote_Click);
            // 
            // HeightTitle
            // 
            this.HeightTitle.AutoSize = true;
            this.HeightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTitle.Location = new System.Drawing.Point(214, 111);
            this.HeightTitle.Name = "HeightTitle";
            this.HeightTitle.Size = new System.Drawing.Size(56, 20);
            this.HeightTitle.TabIndex = 5;
            this.HeightTitle.Text = "Height";
            // 
            // WidthTitle
            // 
            this.WidthTitle.AutoSize = true;
            this.WidthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTitle.Location = new System.Drawing.Point(454, 111);
            this.WidthTitle.Name = "WidthTitle";
            this.WidthTitle.Size = new System.Drawing.Size(50, 20);
            this.WidthTitle.TabIndex = 6;
            this.WidthTitle.Text = "Width";
            // 
            // HeightInputErrorLabel
            // 
            this.HeightInputErrorLabel.AutoSize = true;
            this.HeightInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.HeightInputErrorLabel.Location = new System.Drawing.Point(222, 181);
            this.HeightInputErrorLabel.Name = "HeightInputErrorLabel";
            this.HeightInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.HeightInputErrorLabel.TabIndex = 7;
            this.HeightInputErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthInputErrorLabel
            // 
            this.WidthInputErrorLabel.AutoSize = true;
            this.WidthInputErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WidthInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.WidthInputErrorLabel.Location = new System.Drawing.Point(465, 180);
            this.WidthInputErrorLabel.Name = "WidthInputErrorLabel";
            this.WidthInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthInputErrorLabel.TabIndex = 8;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(218, 134);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(150, 38);
            this.HeightInput.TabIndex = 3;
            this.HeightInput.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(461, 133);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(150, 38);
            this.WidthInput.TabIndex = 4;
            this.WidthInput.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(218, 231);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(150, 39);
            this.MaterialCombo.TabIndex = 5;
            this.MaterialCombo.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rush";
            // 
            // RushCombo
            // 
            this.RushCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushCombo.FormattingEnabled = true;
            this.RushCombo.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushCombo.Location = new System.Drawing.Point(458, 231);
            this.RushCombo.Name = "RushCombo";
            this.RushCombo.Size = new System.Drawing.Size(150, 39);
            this.RushCombo.TabIndex = 6;
            this.RushCombo.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of Drawers";
            // 
            // QuoteAdded
            // 
            this.QuoteAdded.AutoSize = true;
            this.QuoteAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteAdded.ForeColor = System.Drawing.Color.Green;
            this.QuoteAdded.Location = new System.Drawing.Point(659, 346);
            this.QuoteAdded.Name = "QuoteAdded";
            this.QuoteAdded.Size = new System.Drawing.Size(129, 25);
            this.QuoteAdded.TabIndex = 17;
            this.QuoteAdded.Text = "Quote Added";
            this.QuoteAdded.Visible = false;
            // 
            // NotificationTimer
            // 
            this.NotificationTimer.Interval = 2000;
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameBox.Location = new System.Drawing.Point(219, 47);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(150, 38);
            this.CustomerNameBox.TabIndex = 1;
            this.CustomerNameBox.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // CustomerNameTitle
            // 
            this.CustomerNameTitle.AutoSize = true;
            this.CustomerNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTitle.Location = new System.Drawing.Point(215, 24);
            this.CustomerNameTitle.Name = "CustomerNameTitle";
            this.CustomerNameTitle.Size = new System.Drawing.Size(124, 20);
            this.CustomerNameTitle.TabIndex = 19;
            this.CustomerNameTitle.Text = "Customer Name";
            // 
            // DrawerCombo
            // 
            this.DrawerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawerCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerCombo.FormattingEnabled = true;
            this.DrawerCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerCombo.Location = new System.Drawing.Point(461, 47);
            this.DrawerCombo.Name = "DrawerCombo";
            this.DrawerCombo.Size = new System.Drawing.Size(150, 39);
            this.DrawerCombo.TabIndex = 2;
            this.DrawerCombo.TextChanged += new System.EventHandler(this.CheckValidation);
            // 
            // DrawerErrorLabel
            // 
            this.DrawerErrorLabel.AutoSize = true;
            this.DrawerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DrawerErrorLabel.Location = new System.Drawing.Point(465, 96);
            this.DrawerErrorLabel.Name = "DrawerErrorLabel";
            this.DrawerErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.DrawerErrorLabel.TabIndex = 21;
            // 
            // MaterialErrorLabel
            // 
            this.MaterialErrorLabel.AutoSize = true;
            this.MaterialErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MaterialErrorLabel.Location = new System.Drawing.Point(221, 277);
            this.MaterialErrorLabel.Name = "MaterialErrorLabel";
            this.MaterialErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.MaterialErrorLabel.TabIndex = 22;
            // 
            // RushErrorLabel
            // 
            this.RushErrorLabel.AutoSize = true;
            this.RushErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RushErrorLabel.Location = new System.Drawing.Point(463, 274);
            this.RushErrorLabel.Name = "RushErrorLabel";
            this.RushErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.RushErrorLabel.TabIndex = 23;
            // 
            // CustomerNameErrorLabel
            // 
            this.CustomerNameErrorLabel.AutoSize = true;
            this.CustomerNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CustomerNameErrorLabel.Location = new System.Drawing.Point(223, 89);
            this.CustomerNameErrorLabel.Name = "CustomerNameErrorLabel";
            this.CustomerNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.CustomerNameErrorLabel.TabIndex = 24;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerNameErrorLabel);
            this.Controls.Add(this.RushErrorLabel);
            this.Controls.Add(this.MaterialErrorLabel);
            this.Controls.Add(this.DrawerErrorLabel);
            this.Controls.Add(this.DrawerCombo);
            this.Controls.Add(this.CustomerNameTitle);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.QuoteAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RushCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInputErrorLabel);
            this.Controls.Add(this.HeightInputErrorLabel);
            this.Controls.Add(this.WidthTitle);
            this.Controls.Add(this.HeightTitle);
            this.Controls.Add(this.CancelQuoteBtn);
            this.Controls.Add(this.AddNewQuoteAcceptBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteAcceptBtn;
        private System.Windows.Forms.Button CancelQuoteBtn;
        private System.Windows.Forms.Label HeightTitle;
        private System.Windows.Forms.Label WidthTitle;
        private System.Windows.Forms.Label HeightInputErrorLabel;
        private System.Windows.Forms.Label WidthInputErrorLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RushCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuoteAdded;
        private System.Windows.Forms.Timer NotificationTimer;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Label CustomerNameTitle;
        private System.Windows.Forms.ComboBox DrawerCombo;
        private System.Windows.Forms.Label DrawerErrorLabel;
        private System.Windows.Forms.Label MaterialErrorLabel;
        private System.Windows.Forms.Label RushErrorLabel;
        private System.Windows.Forms.Label CustomerNameErrorLabel;
    }
}