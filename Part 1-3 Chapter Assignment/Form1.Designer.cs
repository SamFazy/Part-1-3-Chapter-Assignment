namespace Part_1_3_Chapter_Assignment
{
    partial class frmBasicInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameInstruction = new System.Windows.Forms.Label();
            this.btnNameEnter = new System.Windows.Forms.Button();
            this.lblHeightInstruction = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnHeightEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.btnAgeEnter = new System.Windows.Forms.Button();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblHeightInfo = new System.Windows.Forms.Label();
            this.lblAgeInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(243, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblNameInstruction
            // 
            this.lblNameInstruction.AutoSize = true;
            this.lblNameInstruction.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInstruction.Location = new System.Drawing.Point(12, 19);
            this.lblNameInstruction.Name = "lblNameInstruction";
            this.lblNameInstruction.Size = new System.Drawing.Size(225, 20);
            this.lblNameInstruction.TabIndex = 1;
            this.lblNameInstruction.Text = "Please type your name here:";
            // 
            // btnNameEnter
            // 
            this.btnNameEnter.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameEnter.Location = new System.Drawing.Point(349, 13);
            this.btnNameEnter.Name = "btnNameEnter";
            this.btnNameEnter.Size = new System.Drawing.Size(75, 33);
            this.btnNameEnter.TabIndex = 2;
            this.btnNameEnter.Text = "Enter";
            this.btnNameEnter.UseVisualStyleBackColor = true;
            this.btnNameEnter.Click += new System.EventHandler(this.btnNameEnter_Click);
            // 
            // lblHeightInstruction
            // 
            this.lblHeightInstruction.AutoSize = true;
            this.lblHeightInstruction.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightInstruction.Location = new System.Drawing.Point(12, 76);
            this.lblHeightInstruction.Name = "lblHeightInstruction";
            this.lblHeightInstruction.Size = new System.Drawing.Size(306, 20);
            this.lblHeightInstruction.TabIndex = 3;
            this.lblHeightInstruction.Text = "Please type your height here in meters:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(324, 71);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 29);
            this.txtHeight.TabIndex = 4;
            // 
            // btnHeightEnter
            // 
            this.btnHeightEnter.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeightEnter.Location = new System.Drawing.Point(434, 71);
            this.btnHeightEnter.Name = "btnHeightEnter";
            this.btnHeightEnter.Size = new System.Drawing.Size(75, 31);
            this.btnHeightEnter.TabIndex = 5;
            this.btnHeightEnter.Text = "Enter";
            this.btnHeightEnter.UseVisualStyleBackColor = true;
            this.btnHeightEnter.Click += new System.EventHandler(this.btnHeightEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter your age:";
            // 
            // numUpDownAge
            // 
            this.numUpDownAge.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownAge.Location = new System.Drawing.Point(196, 133);
            this.numUpDownAge.Name = "numUpDownAge";
            this.numUpDownAge.Size = new System.Drawing.Size(75, 29);
            this.numUpDownAge.TabIndex = 7;
            // 
            // btnAgeEnter
            // 
            this.btnAgeEnter.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgeEnter.Location = new System.Drawing.Point(277, 130);
            this.btnAgeEnter.Name = "btnAgeEnter";
            this.btnAgeEnter.Size = new System.Drawing.Size(75, 31);
            this.btnAgeEnter.TabIndex = 8;
            this.btnAgeEnter.Text = "Enter";
            this.btnAgeEnter.UseVisualStyleBackColor = true;
            this.btnAgeEnter.Click += new System.EventHandler(this.btnAgeEnter_Click);
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInfo.Location = new System.Drawing.Point(430, 19);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(53, 20);
            this.lblNameInfo.TabIndex = 9;
            this.lblNameInfo.Text = "Hello:";
            // 
            // lblHeightInfo
            // 
            this.lblHeightInfo.AutoSize = true;
            this.lblHeightInfo.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightInfo.Location = new System.Drawing.Point(515, 76);
            this.lblHeightInfo.Name = "lblHeightInfo";
            this.lblHeightInfo.Size = new System.Drawing.Size(48, 20);
            this.lblHeightInfo.TabIndex = 10;
            this.lblHeightInfo.Text = "Hello";
            // 
            // lblAgeInfo
            // 
            this.lblAgeInfo.AutoSize = true;
            this.lblAgeInfo.Font = new System.Drawing.Font("November", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeInfo.Location = new System.Drawing.Point(358, 137);
            this.lblAgeInfo.Name = "lblAgeInfo";
            this.lblAgeInfo.Size = new System.Drawing.Size(48, 20);
            this.lblAgeInfo.TabIndex = 11;
            this.lblAgeInfo.Text = "Hello";
            // 
            // frmBasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(936, 183);
            this.Controls.Add(this.lblAgeInfo);
            this.Controls.Add(this.lblHeightInfo);
            this.Controls.Add(this.lblNameInfo);
            this.Controls.Add(this.btnAgeEnter);
            this.Controls.Add(this.numUpDownAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHeightEnter);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeightInstruction);
            this.Controls.Add(this.btnNameEnter);
            this.Controls.Add(this.lblNameInstruction);
            this.Controls.Add(this.txtName);
            this.Name = "frmBasicInput";
            this.Text = "Basic Input";
            this.Load += new System.EventHandler(this.frmBasicInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameInstruction;
        private System.Windows.Forms.Button btnNameEnter;
        private System.Windows.Forms.Label lblHeightInstruction;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnHeightEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownAge;
        private System.Windows.Forms.Button btnAgeEnter;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblHeightInfo;
        private System.Windows.Forms.Label lblAgeInfo;
    }
}

