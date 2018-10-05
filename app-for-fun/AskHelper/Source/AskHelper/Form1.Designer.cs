namespace AskHelper
{
    partial class fMain
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
            this.bNext = new System.Windows.Forms.Button();
            this.lText = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNext.Location = new System.Drawing.Point(15, 316);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(171, 38);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "Go next";
            this.bNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // lText
            // 
            this.lText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lText.Location = new System.Drawing.Point(10, 9);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(617, 304);
            this.lText.TabIndex = 1;
            this.lText.Text = "Hello Cruel World";
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bExit.Location = new System.Drawing.Point(192, 316);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(170, 38);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit X";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Visible = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 401);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.bNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fMain";
            this.Text = "Ask yur friend ...";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.Button bExit;
    }
}

