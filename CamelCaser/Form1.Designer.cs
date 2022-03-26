namespace CamelCaser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rawText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.ignoreItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rawText
            // 
            this.rawText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawText.Location = new System.Drawing.Point(12, 12);
            this.rawText.Multiline = true;
            this.rawText.Name = "rawText";
            this.rawText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawText.Size = new System.Drawing.Size(1237, 547);
            this.rawText.TabIndex = 0;
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultText.CausesValidation = false;
            this.resultText.Location = new System.Drawing.Point(12, 565);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(1237, 640);
            this.resultText.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(12, 1211);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(137, 29);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // ignoreItems
            // 
            this.ignoreItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreItems.Location = new System.Drawing.Point(155, 1211);
            this.ignoreItems.Name = "ignoreItems";
            this.ignoreItems.Size = new System.Drawing.Size(1094, 27);
            this.ignoreItems.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 1272);
            this.Controls.Add(this.ignoreItems);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.rawText);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CamelCaser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox rawText;
        private TextBox resultText;
        private TextBox ignoreItems;
        private Button Convert;
    }
}