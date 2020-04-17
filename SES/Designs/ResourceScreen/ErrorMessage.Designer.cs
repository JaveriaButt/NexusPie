namespace SES.Designs.ResourceScreen
{
    partial class Scrn_ErrorMessage
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
            this.mtbn_OK = new MetroFramework.Controls.MetroButton();
            this.mbtn_Cancel = new MetroFramework.Controls.MetroButton();
            this.Pnl_header = new System.Windows.Forms.Panel();
            this.Pbx_Icon = new System.Windows.Forms.PictureBox();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.mlbl_ErrorText = new System.Windows.Forms.Label();
            this.Pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbn_OK
            // 
            this.mtbn_OK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mtbn_OK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbn_OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtbn_OK.Location = new System.Drawing.Point(319, 158);
            this.mtbn_OK.Name = "mtbn_OK";
            this.mtbn_OK.Size = new System.Drawing.Size(103, 33);
            this.mtbn_OK.TabIndex = 0;
            this.mtbn_OK.Text = "OK";
            this.mtbn_OK.UseCustomBackColor = true;
            this.mtbn_OK.UseCustomForeColor = true;
            this.mtbn_OK.UseSelectable = true;
            this.mtbn_OK.UseStyleColors = true;
            this.mtbn_OK.Click += new System.EventHandler(this.mtbn_OK_Click);
            // 
            // mbtn_Cancel
            // 
            this.mbtn_Cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mbtn_Cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbtn_Cancel.Location = new System.Drawing.Point(428, 158);
            this.mbtn_Cancel.Name = "mbtn_Cancel";
            this.mbtn_Cancel.Size = new System.Drawing.Size(102, 33);
            this.mbtn_Cancel.TabIndex = 1;
            this.mbtn_Cancel.Text = "Cancel";
            this.mbtn_Cancel.UseCustomBackColor = true;
            this.mbtn_Cancel.UseCustomForeColor = true;
            this.mbtn_Cancel.UseSelectable = true;
            this.mbtn_Cancel.UseStyleColors = true;
            this.mbtn_Cancel.Click += new System.EventHandler(this.mbtn_Cancel_Click);
            // 
            // Pnl_header
            // 
            this.Pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_header.BackColor = System.Drawing.Color.OrangeRed;
            this.Pnl_header.Controls.Add(this.lbl_Heading);
            this.Pnl_header.Location = new System.Drawing.Point(0, 0);
            this.Pnl_header.Name = "Pnl_header";
            this.Pnl_header.Size = new System.Drawing.Size(556, 38);
            this.Pnl_header.TabIndex = 2;
            // 
            // Pbx_Icon
            // 
            this.Pbx_Icon.Location = new System.Drawing.Point(428, 44);
            this.Pbx_Icon.Name = "Pbx_Icon";
            this.Pbx_Icon.Size = new System.Drawing.Size(102, 96);
            this.Pbx_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Icon.TabIndex = 1;
            this.Pbx_Icon.TabStop = false;
            this.Pbx_Icon.Click += new System.EventHandler(this.Pbx_Icon_Click);
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Heading.Location = new System.Drawing.Point(161, 6);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(59, 25);
            this.lbl_Heading.TabIndex = 0;
            this.lbl_Heading.Text = "Error";
            // 
            // mlbl_ErrorText
            // 
            this.mlbl_ErrorText.AutoSize = true;
            this.mlbl_ErrorText.BackColor = System.Drawing.Color.Transparent;
            this.mlbl_ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_ErrorText.ForeColor = System.Drawing.Color.AliceBlue;
            this.mlbl_ErrorText.Location = new System.Drawing.Point(12, 75);
            this.mlbl_ErrorText.Name = "mlbl_ErrorText";
            this.mlbl_ErrorText.Size = new System.Drawing.Size(133, 20);
            this.mlbl_ErrorText.TabIndex = 1;
            this.mlbl_ErrorText.Text = "Error Message";
            // 
            // Scrn_ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(558, 203);
            this.ControlBox = false;
            this.Controls.Add(this.Pbx_Icon);
            this.Controls.Add(this.mlbl_ErrorText);
            this.Controls.Add(this.Pnl_header);
            this.Controls.Add(this.mbtn_Cancel);
            this.Controls.Add(this.mtbn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Scrn_ErrorMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Pnl_header.ResumeLayout(false);
            this.Pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mtbn_OK;
        private MetroFramework.Controls.MetroButton mbtn_Cancel;
        private System.Windows.Forms.Panel Pnl_header;
        public System.Windows.Forms.Label lbl_Heading;
        public System.Windows.Forms.Label mlbl_ErrorText;
        public System.Windows.Forms.PictureBox Pbx_Icon;
    }
}