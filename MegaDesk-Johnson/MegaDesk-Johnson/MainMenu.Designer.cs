namespace MegaDesk_Johnson
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
            this.AddQuote = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuote
            // 
            this.AddQuote.AutoSize = true;
            this.AddQuote.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuote.Location = new System.Drawing.Point(12, 12);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(156, 34);
            this.AddQuote.TabIndex = 0;
            this.AddQuote.Text = "Add New Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.AutoSize = true;
            this.ViewButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(12, 78);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(156, 34);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View Quotes";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 215);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 34);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(12, 147);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search Quotes";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.AddQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuote;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchButton;
    }
}

