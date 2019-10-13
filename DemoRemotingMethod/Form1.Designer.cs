namespace DemoRemotingMethod
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
            this.btConnect = new System.Windows.Forms.Button();
            this.btGetNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(75, 50);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(168, 63);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // btGetNotes
            // 
            this.btGetNotes.Location = new System.Drawing.Point(309, 50);
            this.btGetNotes.Name = "btGetNotes";
            this.btGetNotes.Size = new System.Drawing.Size(184, 63);
            this.btGetNotes.TabIndex = 1;
            this.btGetNotes.Text = "Get notes";
            this.btGetNotes.UseVisualStyleBackColor = true;
            this.btGetNotes.Click += new System.EventHandler(this.BtGetNotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 296);
            this.Controls.Add(this.btGetNotes);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btGetNotes;
    }
}

