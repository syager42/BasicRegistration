namespace Registration
{
    partial class WaitlistForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonJoinWaitlist = new System.Windows.Forms.Button();
            this.buttonDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class is currently full";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Would you like to be added to the waitlist?";
            // 
            // buttonJoinWaitlist
            // 
            this.buttonJoinWaitlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJoinWaitlist.Location = new System.Drawing.Point(29, 113);
            this.buttonJoinWaitlist.Name = "buttonJoinWaitlist";
            this.buttonJoinWaitlist.Size = new System.Drawing.Size(93, 31);
            this.buttonJoinWaitlist.TabIndex = 2;
            this.buttonJoinWaitlist.Text = "Join Waitlist";
            this.buttonJoinWaitlist.UseVisualStyleBackColor = true;
            this.buttonJoinWaitlist.Click += new System.EventHandler(this.buttonJoinWaitlist_Click);
            // 
            // buttonDecline
            // 
            this.buttonDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecline.Location = new System.Drawing.Point(249, 113);
            this.buttonDecline.Name = "buttonDecline";
            this.buttonDecline.Size = new System.Drawing.Size(93, 31);
            this.buttonDecline.TabIndex = 3;
            this.buttonDecline.Text = "Decline";
            this.buttonDecline.UseVisualStyleBackColor = true;
            this.buttonDecline.Click += new System.EventHandler(this.buttonDecline_Click);
            // 
            // WaitlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.buttonDecline);
            this.Controls.Add(this.buttonJoinWaitlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WaitlistForm";
            this.Text = "WaitlistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonJoinWaitlist;
        private System.Windows.Forms.Button buttonDecline;
    }
}