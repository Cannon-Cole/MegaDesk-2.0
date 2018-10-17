namespace MegaDesk_4_ColeCannon
{
    partial class ViewAllQuotes
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
            this.ViewQuotesBackBtn = new System.Windows.Forms.Button();
            this.SearchTitle = new System.Windows.Forms.Label();
            this.ViewAllDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ViewQuotesBackBtn
            // 
            this.ViewQuotesBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBackBtn.Location = new System.Drawing.Point(303, 388);
            this.ViewQuotesBackBtn.Name = "ViewQuotesBackBtn";
            this.ViewQuotesBackBtn.Size = new System.Drawing.Size(195, 50);
            this.ViewQuotesBackBtn.TabIndex = 2;
            this.ViewQuotesBackBtn.Text = "&Back";
            this.ViewQuotesBackBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBackBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchTitle
            // 
            this.SearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTitle.Location = new System.Drawing.Point(327, 17);
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.Size = new System.Drawing.Size(152, 42);
            this.SearchTitle.TabIndex = 13;
            this.SearchTitle.Text = "All Quotes";
            // 
            // ViewAllDisplay
            // 
            this.ViewAllDisplay.Location = new System.Drawing.Point(97, 56);
            this.ViewAllDisplay.Name = "ViewAllDisplay";
            this.ViewAllDisplay.Size = new System.Drawing.Size(611, 326);
            this.ViewAllDisplay.TabIndex = 15;
            this.ViewAllDisplay.UseCompatibleStateImageBehavior = false;
            this.ViewAllDisplay.View = System.Windows.Forms.View.Details;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAllDisplay);
            this.Controls.Add(this.SearchTitle);
            this.Controls.Add(this.ViewQuotesBackBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewQuotesBackBtn;
        private System.Windows.Forms.Label SearchTitle;
        private System.Windows.Forms.ListView ViewAllDisplay;
    }
}