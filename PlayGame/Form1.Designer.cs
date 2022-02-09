namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.Color.Black;
            this.PlayGameButton.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.Location = new System.Drawing.Point(260, 104);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(264, 77);
            this.PlayGameButton.TabIndex = 2;
            this.PlayGameButton.Text = "Play Game?";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // GO
            // 
            this.GO.AutoSize = true;
            this.GO.BackColor = System.Drawing.Color.Gainsboro;
            this.GO.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GO.Location = new System.Drawing.Point(0, -1);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(151, 72);
            this.GO.TabIndex = 3;
            this.GO.Text = "GO!";
            this.GO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GO.Visible = false;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(916, 484);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.PlayGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Play Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label GO;
    }
}

