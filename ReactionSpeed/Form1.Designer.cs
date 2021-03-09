namespace ReactionSpeed
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
            this.components = new System.ComponentModel.Container();
            this.bttnReaction = new System.Windows.Forms.Button();
            this.bttnClick = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnReaction
            // 
            this.bttnReaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnReaction.Location = new System.Drawing.Point(157, 137);
            this.bttnReaction.Name = "bttnReaction";
            this.bttnReaction.Size = new System.Drawing.Size(115, 76);
            this.bttnReaction.TabIndex = 0;
            this.bttnReaction.TabStop = false;
            this.bttnReaction.Text = "Test your reactions";
            this.bttnReaction.UseVisualStyleBackColor = true;
            this.bttnReaction.Click += new System.EventHandler(this.bttnReaction_Click);
            // 
            // bttnClick
            // 
            this.bttnClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnClick.CausesValidation = false;
            this.bttnClick.Location = new System.Drawing.Point(157, 257);
            this.bttnClick.Margin = new System.Windows.Forms.Padding(1);
            this.bttnClick.Name = "bttnClick";
            this.bttnClick.Padding = new System.Windows.Forms.Padding(1);
            this.bttnClick.Size = new System.Drawing.Size(115, 76);
            this.bttnClick.TabIndex = 1;
            this.bttnClick.TabStop = false;
            this.bttnClick.Text = "Click Me";
            this.bttnClick.UseVisualStyleBackColor = true;
            this.bttnClick.Visible = false;
            this.bttnClick.Click += new System.EventHandler(this.bttnClick_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttnSave
            // 
            this.bttnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnSave.Location = new System.Drawing.Point(303, 379);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(113, 43);
            this.bttnSave.TabIndex = 2;
            this.bttnSave.TabStop = false;
            this.bttnSave.Text = "Save ReactionTime";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Visible = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnRestart
            // 
            this.bttnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnRestart.Location = new System.Drawing.Point(12, 379);
            this.bttnRestart.Name = "bttnRestart";
            this.bttnRestart.Size = new System.Drawing.Size(113, 43);
            this.bttnRestart.TabIndex = 3;
            this.bttnRestart.TabStop = false;
            this.bttnRestart.Text = "Restart";
            this.bttnRestart.UseVisualStyleBackColor = true;
            this.bttnRestart.Visible = false;
            this.bttnRestart.Click += new System.EventHandler(this.bttnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 434);
            this.Controls.Add(this.bttnRestart);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnClick);
            this.Controls.Add(this.bttnReaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnReaction;
        private System.Windows.Forms.Button bttnClick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnRestart;
    }
}

