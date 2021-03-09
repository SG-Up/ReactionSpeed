namespace ReactionSpeed
{
    partial class Form2
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
            this.bttnOpen = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.txtMeanTime = new System.Windows.Forms.TextBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttnOpen
            // 
            this.bttnOpen.Location = new System.Drawing.Point(205, 59);
            this.bttnOpen.Name = "bttnOpen";
            this.bttnOpen.Size = new System.Drawing.Size(113, 43);
            this.bttnOpen.TabIndex = 0;
            this.bttnOpen.TabStop = false;
            this.bttnOpen.Text = "Open List";
            this.bttnOpen.UseVisualStyleBackColor = true;
            this.bttnOpen.Click += new System.EventHandler(this.bttnOpen_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 5;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(53, 59);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(113, 43);
            this.bttnSave.TabIndex = 6;
            this.bttnSave.TabStop = false;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(202, 11);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(63, 13);
            this.lblMean.TabIndex = 8;
            this.lblMean.Text = "Mean Time:";
            // 
            // txtMeanTime
            // 
            this.txtMeanTime.Location = new System.Drawing.Point(272, 11);
            this.txtMeanTime.Name = "txtMeanTime";
            this.txtMeanTime.ReadOnly = true;
            this.txtMeanTime.Size = new System.Drawing.Size(46, 20);
            this.txtMeanTime.TabIndex = 9;
            this.txtMeanTime.TextChanged += new System.EventHandler(this.txtMeanTime_TextChanged);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(238, 36);
            this.chkMax.Name = "chkMax";
            this.chkMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMax.Size = new System.Drawing.Size(78, 17);
            this.chkMax.TabIndex = 10;
            this.chkMax.Text = ":Maximized";
            this.chkMax.UseVisualStyleBackColor = true;
            this.chkMax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 114);
            this.Controls.Add(this.chkMax);
            this.Controls.Add(this.txtMeanTime);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bttnOpen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnOpen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.TextBox txtMeanTime;
        private System.Windows.Forms.CheckBox chkMax;
    }
}