namespace FactorialCalculator
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
            this.nbrArea = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.topText = new System.Windows.Forms.Label();
            this.nbrText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rsltBox = new System.Windows.Forms.TextBox();
            this.creatorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nbrArea
            // 
            this.nbrArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrArea.Location = new System.Drawing.Point(323, 164);
            this.nbrArea.Name = "nbrArea";
            this.nbrArea.Size = new System.Drawing.Size(291, 27);
            this.nbrArea.TabIndex = 0;
            this.nbrArea.TextChanged += new System.EventHandler(this.nbrArea_TextChanged);
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcBtn.Location = new System.Drawing.Point(267, 398);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(202, 55);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "CALCULATE";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topText.ForeColor = System.Drawing.Color.Orange;
            this.topText.Location = new System.Drawing.Point(105, 47);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(533, 59);
            this.topText.TabIndex = 2;
            this.topText.Text = "FACTORIAL CALCULATOR";
            this.topText.Click += new System.EventHandler(this.label1_Click);
            // 
            // nbrText
            // 
            this.nbrText.AutoSize = true;
            this.nbrText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbrText.ForeColor = System.Drawing.Color.Orange;
            this.nbrText.Location = new System.Drawing.Point(206, 164);
            this.nbrText.Name = "nbrText";
            this.nbrText.Size = new System.Drawing.Size(95, 28);
            this.nbrText.TabIndex = 3;
            this.nbrText.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(206, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result:";
            // 
            // rsltBox
            // 
            this.rsltBox.Location = new System.Drawing.Point(323, 242);
            this.rsltBox.Multiline = true;
            this.rsltBox.Name = "rsltBox";
            this.rsltBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rsltBox.Size = new System.Drawing.Size(291, 121);
            this.rsltBox.TabIndex = 5;
            // 
            // creatorName
            // 
            this.creatorName.AutoSize = true;
            this.creatorName.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creatorName.ForeColor = System.Drawing.Color.Orange;
            this.creatorName.Location = new System.Drawing.Point(12, 481);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(315, 20);
            this.creatorName.TabIndex = 6;
            this.creatorName.Text = "This program was created by Ridvan KARASUBASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(752, 510);
            this.Controls.Add(this.creatorName);
            this.Controls.Add(this.rsltBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbrText);
            this.Controls.Add(this.topText);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.nbrArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nbrArea;
        private Button calcBtn;
        private Label topText;
        private Label nbrText;
        private Label label1;
        private TextBox rsltBox;
        private Label creatorName;
    }
}