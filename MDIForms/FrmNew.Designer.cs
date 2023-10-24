namespace MDIForms
{
    partial class FrmNew
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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLine.Location = new System.Drawing.Point(21, 391);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(105, 31);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "LINE";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRect.Location = new System.Drawing.Point(132, 391);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(139, 31);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "RECTANGLE";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnArc
            // 
            this.btnArc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArc.Location = new System.Drawing.Point(277, 391);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(105, 31);
            this.btnArc.TabIndex = 2;
            this.btnArc.Text = "ARC";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnPie
            // 
            this.btnPie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPie.Location = new System.Drawing.Point(388, 391);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(105, 31);
            this.btnPie.TabIndex = 3;
            this.btnPie.Text = "PIE";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnEllips
            // 
            this.btnEllips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEllips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEllips.Location = new System.Drawing.Point(499, 391);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(105, 31);
            this.btnEllips.TabIndex = 4;
            this.btnEllips.Text = "ELLIPS";
            this.btnEllips.UseVisualStyleBackColor = true;
            this.btnEllips.Click += new System.EventHandler(this.btnEllips_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCurve.Location = new System.Drawing.Point(610, 391);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(105, 31);
            this.btnCurve.TabIndex = 5;
            this.btnCurve.Text = "CURVE";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // FrmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCurve);
            this.Controls.Add(this.btnEllips);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnLine);
            this.Name = "FrmNew";
            this.Text = "FrmNew";
            this.Load += new System.EventHandler(this.FrmNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnCurve;
    }
}