namespace SOEE_Import
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.linkLabelTrelloKey = new System.Windows.Forms.LinkLabel();
            this.labelTrelloAndOAuthKey = new System.Windows.Forms.Label();
            this.labelTrelloAPIKey = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.txtOAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutput.Location = new System.Drawing.Point(6, 16);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(366, 407);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "lblOutput";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.lblOutput);
            this.gbOutput.Location = new System.Drawing.Point(410, 12);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(378, 426);
            this.gbOutput.TabIndex = 1;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // linkLabelTrelloKey
            // 
            this.linkLabelTrelloKey.AutoSize = true;
            this.linkLabelTrelloKey.Location = new System.Drawing.Point(149, 12);
            this.linkLabelTrelloKey.Name = "linkLabelTrelloKey";
            this.linkLabelTrelloKey.Size = new System.Drawing.Size(131, 13);
            this.linkLabelTrelloKey.TabIndex = 2;
            this.linkLabelTrelloKey.TabStop = true;
            this.linkLabelTrelloKey.Text = "https://trello.com/app-key";
            // 
            // labelTrelloAndOAuthKey
            // 
            this.labelTrelloAndOAuthKey.AutoSize = true;
            this.labelTrelloAndOAuthKey.Location = new System.Drawing.Point(12, 12);
            this.labelTrelloAndOAuthKey.Name = "labelTrelloAndOAuthKey";
            this.labelTrelloAndOAuthKey.Size = new System.Drawing.Size(131, 13);
            this.labelTrelloAndOAuthKey.TabIndex = 3;
            this.labelTrelloAndOAuthKey.Text = "Trello API and OAuth Key:";
            // 
            // labelTrelloAPIKey
            // 
            this.labelTrelloAPIKey.AutoSize = true;
            this.labelTrelloAPIKey.Location = new System.Drawing.Point(12, 39);
            this.labelTrelloAPIKey.Name = "labelTrelloAPIKey";
            this.labelTrelloAPIKey.Size = new System.Drawing.Size(77, 13);
            this.labelTrelloAPIKey.TabIndex = 4;
            this.labelTrelloAPIKey.Text = "Trello API Key:";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(95, 36);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(309, 20);
            this.txtAPIKey.TabIndex = 5;
            this.txtAPIKey.UseSystemPasswordChar = true;
            // 
            // txtOAuth
            // 
            this.txtOAuth.Location = new System.Drawing.Point(95, 62);
            this.txtOAuth.Name = "txtOAuth";
            this.txtOAuth.Size = new System.Drawing.Size(309, 20);
            this.txtOAuth.TabIndex = 7;
            this.txtOAuth.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trello OAuth:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOAuth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.labelTrelloAPIKey);
            this.Controls.Add(this.labelTrelloAndOAuthKey);
            this.Controls.Add(this.linkLabelTrelloKey);
            this.Controls.Add(this.gbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fernleigh SOEE Import Tool";
            this.gbOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.LinkLabel linkLabelTrelloKey;
        private System.Windows.Forms.Label labelTrelloAndOAuthKey;
        private System.Windows.Forms.Label labelTrelloAPIKey;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.TextBox txtOAuth;
        private System.Windows.Forms.Label label1;
    }
}

