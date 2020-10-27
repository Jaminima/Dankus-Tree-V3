namespace DankusTreeV3
{
    partial class DankusTree
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
            this.treeLight7 = new DankusTreeV3.TreeLight();
            this.treeLight6 = new DankusTreeV3.TreeLight();
            this.treeLight5 = new DankusTreeV3.TreeLight();
            this.treeLight4 = new DankusTreeV3.TreeLight();
            this.treeLight3 = new DankusTreeV3.TreeLight();
            this.treeLight2 = new DankusTreeV3.TreeLight();
            this.treeLight1 = new DankusTreeV3.TreeLight();
            this.SuspendLayout();
            // 
            // tmr_Snow
            // 
            this.tmr_Snow.Enabled = true;
            this.tmr_Snow.Interval = 30;
            this.tmr_Snow.Tick += new System.EventHandler(this.tmr_Snow_Tick);
            // 
            // treeLight7
            // 
            this.treeLight7.BackColor = System.Drawing.Color.Red;
            this.treeLight7.Location = new System.Drawing.Point(381, 429);
            this.treeLight7.Name = "treeLight7";
            this.treeLight7.Size = new System.Drawing.Size(5, 5);
            this.treeLight7.TabIndex = 6;
            // 
            // treeLight6
            // 
            this.treeLight6.BackColor = System.Drawing.Color.Green;
            this.treeLight6.Location = new System.Drawing.Point(352, 333);
            this.treeLight6.Name = "treeLight6";
            this.treeLight6.Size = new System.Drawing.Size(5, 5);
            this.treeLight6.TabIndex = 5;
            // 
            // treeLight5
            // 
            this.treeLight5.BackColor = System.Drawing.Color.Green;
            this.treeLight5.Location = new System.Drawing.Point(270, 243);
            this.treeLight5.Name = "treeLight5";
            this.treeLight5.Size = new System.Drawing.Size(5, 5);
            this.treeLight5.TabIndex = 4;
            // 
            // treeLight4
            // 
            this.treeLight4.BackColor = System.Drawing.Color.Green;
            this.treeLight4.Location = new System.Drawing.Point(293, 317);
            this.treeLight4.Name = "treeLight4";
            this.treeLight4.Size = new System.Drawing.Size(5, 5);
            this.treeLight4.TabIndex = 3;
            // 
            // treeLight3
            // 
            this.treeLight3.BackColor = System.Drawing.Color.Green;
            this.treeLight3.Location = new System.Drawing.Point(293, 387);
            this.treeLight3.Name = "treeLight3";
            this.treeLight3.Size = new System.Drawing.Size(5, 5);
            this.treeLight3.TabIndex = 2;
            // 
            // treeLight2
            // 
            this.treeLight2.BackColor = System.Drawing.Color.Red;
            this.treeLight2.Location = new System.Drawing.Point(259, 356);
            this.treeLight2.Name = "treeLight2";
            this.treeLight2.Size = new System.Drawing.Size(5, 5);
            this.treeLight2.TabIndex = 1;
            // 
            // treeLight1
            // 
            this.treeLight1.BackColor = System.Drawing.Color.White;
            this.treeLight1.Location = new System.Drawing.Point(235, 430);
            this.treeLight1.Name = "treeLight1";
            this.treeLight1.Size = new System.Drawing.Size(5, 5);
            this.treeLight1.TabIndex = 0;
            // 
            // DankusTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 620);
            this.Controls.Add(this.treeLight7);
            this.Controls.Add(this.treeLight6);
            this.Controls.Add(this.treeLight5);
            this.Controls.Add(this.treeLight4);
            this.Controls.Add(this.treeLight3);
            this.Controls.Add(this.treeLight2);
            this.Controls.Add(this.treeLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DankusTree";
            this.Text = "DanksTree V3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Snow;
        private TreeLight treeLight1;
        private TreeLight treeLight2;
        private TreeLight treeLight3;
        private TreeLight treeLight4;
        private TreeLight treeLight5;
        private TreeLight treeLight6;
        private TreeLight treeLight7;
    }
}

