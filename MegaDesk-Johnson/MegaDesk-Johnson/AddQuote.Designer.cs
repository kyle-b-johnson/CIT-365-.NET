
namespace MegaDesk_Johnson
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
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDepth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericDrawers = new System.Windows.Forms.NumericUpDown();
            this.surfaceBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getQuoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameBox
            // 
            this.fNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.Location = new System.Drawing.Point(22, 91);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(154, 32);
            this.fNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lNameBox
            // 
            this.lNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.Location = new System.Drawing.Point(22, 149);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(237, 32);
            this.lNameBox.TabIndex = 1;
            this.lNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Get a Quote";
            // 
            // numericWidth
            // 
            this.numericWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericWidth.Location = new System.Drawing.Point(22, 207);
            this.numericWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(120, 29);
            this.numericWidth.TabIndex = 3;
            this.numericWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(19, 184);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(55, 20);
            this.deskWidth.TabIndex = 6;
            this.deskWidth.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Depth";
            // 
            // numericDepth
            // 
            this.numericDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDepth.Location = new System.Drawing.Point(22, 262);
            this.numericDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericDepth.Name = "numericDepth";
            this.numericDepth.Size = new System.Drawing.Size(120, 29);
            this.numericDepth.TabIndex = 4;
            this.numericDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Drawers";
            // 
            // numericDrawers
            // 
            this.numericDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDrawers.Location = new System.Drawing.Point(22, 317);
            this.numericDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericDrawers.Name = "numericDrawers";
            this.numericDrawers.Size = new System.Drawing.Size(120, 29);
            this.numericDrawers.TabIndex = 5;
            // 
            // surfaceBox
            // 
            this.surfaceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.surfaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceBox.FormattingEnabled = true;
            this.surfaceBox.Location = new System.Drawing.Point(23, 372);
            this.surfaceBox.Name = "surfaceBox";
            this.surfaceBox.Size = new System.Drawing.Size(121, 32);
            this.surfaceBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desktop Surface Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rush Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "days";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.AutoSize = true;
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(101, 496);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(126, 40);
            this.getQuoteButton.TabIndex = 8;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.getQuoteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 548);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surfaceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDrawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNameBox);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericDrawers;
        private System.Windows.Forms.ComboBox surfaceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button getQuoteButton;
    }
}