namespace DankusTreeV3
{
    partial class TreeLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_Flash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmr_Flash
            // 
            this.tmr_Flash.Enabled = true;
            this.tmr_Flash.Tick += new System.EventHandler(this.tmr_Flash_Tick);
            // 
            // TreeLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TreeLight";
            this.Size = new System.Drawing.Size(5, 5);
            this.Load += new System.EventHandler(this.TreeLight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Flash;
    }
}
