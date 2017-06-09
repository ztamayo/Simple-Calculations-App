namespace Simple_Calculations_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.snlabel = new System.Windows.Forms.Label();
            this.fnTextbox = new System.Windows.Forms.TextBox();
            this.snTextbox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.diffButton = new System.Windows.Forms.Button();
            this.prodButton = new System.Windows.Forms.Button();
            this.quotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Calculations";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(42, 78);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(100, 20);
            this.fnLabel.TabIndex = 1;
            this.fnLabel.Text = "First Number";
            // 
            // snlabel
            // 
            this.snlabel.AutoSize = true;
            this.snlabel.Location = new System.Drawing.Point(42, 117);
            this.snlabel.Name = "snlabel";
            this.snlabel.Size = new System.Drawing.Size(124, 20);
            this.snlabel.TabIndex = 2;
            this.snlabel.Text = "Second Number";
            // 
            // fnTextbox
            // 
            this.fnTextbox.Location = new System.Drawing.Point(237, 72);
            this.fnTextbox.Name = "fnTextbox";
            this.fnTextbox.Size = new System.Drawing.Size(100, 26);
            this.fnTextbox.TabIndex = 3;
            // 
            // snTextbox
            // 
            this.snTextbox.Location = new System.Drawing.Point(237, 117);
            this.snTextbox.Name = "snTextbox";
            this.snTextbox.Size = new System.Drawing.Size(100, 26);
            this.snTextbox.TabIndex = 4;
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.Location = new System.Drawing.Point(42, 176);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(295, 53);
            this.resultsLabel.TabIndex = 5;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(12, 259);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 32);
            this.sumButton.TabIndex = 6;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(97, 308);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 32);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diffButton
            // 
            this.diffButton.Location = new System.Drawing.Point(109, 259);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(75, 32);
            this.diffButton.TabIndex = 9;
            this.diffButton.Text = "Diff";
            this.diffButton.UseVisualStyleBackColor = true;
            this.diffButton.Click += new System.EventHandler(this.diffButton_Click);
            // 
            // prodButton
            // 
            this.prodButton.Location = new System.Drawing.Point(203, 259);
            this.prodButton.Name = "prodButton";
            this.prodButton.Size = new System.Drawing.Size(75, 32);
            this.prodButton.TabIndex = 10;
            this.prodButton.Text = "Prod";
            this.prodButton.UseVisualStyleBackColor = true;
            this.prodButton.Click += new System.EventHandler(this.prodButton_Click);
            // 
            // quotButton
            // 
            this.quotButton.Location = new System.Drawing.Point(298, 259);
            this.quotButton.Name = "quotButton";
            this.quotButton.Size = new System.Drawing.Size(75, 32);
            this.quotButton.TabIndex = 11;
            this.quotButton.Text = "Quot";
            this.quotButton.UseVisualStyleBackColor = true;
            this.quotButton.Click += new System.EventHandler(this.quotButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 364);
            this.Controls.Add(this.quotButton);
            this.Controls.Add(this.prodButton);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.snTextbox);
            this.Controls.Add(this.fnTextbox);
            this.Controls.Add(this.snlabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Week 1 Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label snlabel;
        private System.Windows.Forms.TextBox fnTextbox;
        private System.Windows.Forms.TextBox snTextbox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Button prodButton;
        private System.Windows.Forms.Button quotButton;
    }
}

