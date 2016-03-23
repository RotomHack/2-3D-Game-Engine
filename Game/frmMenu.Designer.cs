namespace Game_Engine
{
    partial class frmMenu
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
            this.bnNewGame = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnNewGame
            // 
            this.bnNewGame.Location = new System.Drawing.Point(91, 43);
            this.bnNewGame.Name = "bnNewGame";
            this.bnNewGame.Size = new System.Drawing.Size(110, 34);
            this.bnNewGame.TabIndex = 0;
            this.bnNewGame.Text = "New Game";
            this.bnNewGame.UseVisualStyleBackColor = true;
            this.bnNewGame.Click += new System.EventHandler(this.bnNewGame_Click);
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(106, 111);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(75, 35);
            this.bnExit.TabIndex = 1;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.bnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Click += new System.EventHandler(this.frmMenu_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnNewGame;
        private System.Windows.Forms.Button bnExit;
    }
}