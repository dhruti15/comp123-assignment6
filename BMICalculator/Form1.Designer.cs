namespace BMICalculator
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
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.textBoxDisplayBMI = new System.Windows.Forms.TextBox();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.labelKilo = new System.Windows.Forms.Label();
            this.labelMeters = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInches = new System.Windows.Forms.Label();
            this.labelPounds = new System.Windows.Forms.Label();
            this.textBoxMultiline = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(142, 4);
            this.radioButtonMetric.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(62, 20);
            this.radioButtonMetric.TabIndex = 1;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            this.radioButtonMetric.Click += new System.EventHandler(this.radioButtonMetric_Click);
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(4, 4);
            this.radioButtonImperial.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(74, 20);
            this.radioButtonImperial.TabIndex = 0;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.radioButtonImperial_CheckedChanged);
            this.radioButtonImperial.Click += new System.EventHandler(this.radioButtonImperial_Click);
            // 
            // textBoxDisplayBMI
            // 
            this.textBoxDisplayBMI.Location = new System.Drawing.Point(142, 239);
            this.textBoxDisplayBMI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDisplayBMI.Name = "textBoxDisplayBMI";
            this.textBoxDisplayBMI.Size = new System.Drawing.Size(62, 22);
            this.textBoxDisplayBMI.TabIndex = 9;
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(4, 239);
            this.buttonCalculateBMI.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(108, 28);
            this.buttonCalculateBMI.TabIndex = 8;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // labelKilo
            // 
            this.labelKilo.AutoSize = true;
            this.labelKilo.Location = new System.Drawing.Point(233, 153);
            this.labelKilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKilo.Name = "labelKilo";
            this.labelKilo.Size = new System.Drawing.Size(61, 16);
            this.labelKilo.TabIndex = 7;
            this.labelKilo.Text = "Kilogram";
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(233, 58);
            this.labelMeters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(49, 16);
            this.labelMeters.TabIndex = 6;
            this.labelMeters.Text = "Meters";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(142, 157);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(62, 22);
            this.textBoxWeight.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(142, 62);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(62, 22);
            this.textBoxHeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Height";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.26201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.73799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMeters, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKilo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalculateBMI, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplayBMI, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonImperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMetric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInches, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPounds, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMultiline, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.81094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.18906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelInches
            // 
            this.labelInches.AutoSize = true;
            this.labelInches.Location = new System.Drawing.Point(322, 58);
            this.labelInches.Name = "labelInches";
            this.labelInches.Size = new System.Drawing.Size(47, 16);
            this.labelInches.TabIndex = 10;
            this.labelInches.Text = "Inches";
            // 
            // labelPounds
            // 
            this.labelPounds.AutoSize = true;
            this.labelPounds.Location = new System.Drawing.Point(322, 153);
            this.labelPounds.Name = "labelPounds";
            this.labelPounds.Size = new System.Drawing.Size(54, 16);
            this.labelPounds.TabIndex = 11;
            this.labelPounds.Text = "Pounds";
            // 
            // textBoxMultiline
            // 
            this.textBoxMultiline.Location = new System.Drawing.Point(141, 299);
            this.textBoxMultiline.Multiline = true;
            this.textBoxMultiline.Name = "textBoxMultiline";
            this.textBoxMultiline.Size = new System.Drawing.Size(85, 45);
            this.textBoxMultiline.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.TextBox textBoxDisplayBMI;
        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.Label labelKilo;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInches;
        private System.Windows.Forms.Label labelPounds;
        private System.Windows.Forms.TextBox textBoxMultiline;

    }
}

