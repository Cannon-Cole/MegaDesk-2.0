namespace MegaDesk_4_ColeCannon
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddNewQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuoteBtn
            // 
            this.AddNewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteBtn.Location = new System.Drawing.Point(102, 66);
            this.AddNewQuoteBtn.Name = "AddNewQuoteBtn";
            this.AddNewQuoteBtn.Size = new System.Drawing.Size(195, 65);
            this.AddNewQuoteBtn.TabIndex = 0;
            this.AddNewQuoteBtn.Text = "&Add New Quote";
            this.AddNewQuoteBtn.UseVisualStyleBackColor = true;
            this.AddNewQuoteBtn.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBtn.Location = new System.Drawing.Point(102, 137);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(195, 65);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "&View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesBtn.Location = new System.Drawing.Point(102, 208);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(195, 65);
            this.SearchQuotesBtn.TabIndex = 2;
            this.SearchQuotesBtn.Text = "&Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(102, 279);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(195, 65);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddNewQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

