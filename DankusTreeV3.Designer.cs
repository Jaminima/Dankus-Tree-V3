namespace DankusTreeV3
{
    partial class DankusTreeV3
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
            this.tmr_Snow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmr_Snow
            // 
            this.tmr_Snow.Enabled = true;
            this.tmr_Snow.Interval = 10;
            this.tmr_Snow.Tick += new System.EventHandler(this.tmr_Snow_Tick);
            // 
            // DankusTreeV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DankusTreeV3";
            this.Text = "DanksTree V3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Snow;
    }
}

