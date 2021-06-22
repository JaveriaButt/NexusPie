namespace SES
{
    partial class OPtion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPtion));
            this.mt_close = new MetroFramework.Controls.MetroTile();
            this.mt_delete = new MetroFramework.Controls.MetroTile();
            this.mt_update = new MetroFramework.Controls.MetroTile();
            this.mt_add = new MetroFramework.Controls.MetroTile();
            this.Pnl_Header = new MetroFramework.Controls.MetroPanel();
            this.mlbl_header = new System.Windows.Forms.Label();
            this.mt_addMultiple = new MetroFramework.Controls.MetroTile();
            this.mt_UpdateMultipe = new MetroFramework.Controls.MetroTile();
            this.mt_DeleteMultiple = new MetroFramework.Controls.MetroTile();
            this.Pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // mt_close
            // 
            this.mt_close.ActiveControl = null;
            this.mt_close.BackColor = System.Drawing.Color.DodgerBlue;
            this.mt_close.Location = new System.Drawing.Point(171, 344);
            this.mt_close.Margin = new System.Windows.Forms.Padding(4);
            this.mt_close.Name = "mt_close";
            this.mt_close.Size = new System.Drawing.Size(189, 73);
            this.mt_close.TabIndex = 3;
            this.mt_close.Text = "Close ";
            this.mt_close.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_close.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_close.TileImage")));
            this.mt_close.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mt_close.UseCustomBackColor = true;
            this.mt_close.UseCustomForeColor = true;
            this.mt_close.UseMnemonic = false;
            ////this.mt_close.USESelectable = true;
            //       //this.mt_close.USEStyleColors = true;
            this.mt_close.UseTileImage = true;
            this.mt_close.Click += new System.EventHandler(this.mt_close_Click);
            // 
            // mt_delete
            // 
            this.mt_delete.ActiveControl = null;
            this.mt_delete.BackColor = System.Drawing.Color.MediumPurple;
            this.mt_delete.Location = new System.Drawing.Point(26, 248);
            this.mt_delete.Margin = new System.Windows.Forms.Padding(4);
            this.mt_delete.Name = "mt_delete";
            this.mt_delete.Size = new System.Drawing.Size(189, 73);
            this.mt_delete.TabIndex = 2;
            this.mt_delete.Text = "Delete Record";
            this.mt_delete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_delete.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_delete.TileImage")));
            this.mt_delete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mt_delete.UseCustomBackColor = true;
            this.mt_delete.UseCustomForeColor = true;
            this.mt_delete.UseMnemonic = false;
            this.mt_delete.USESelectable = true;
            this.mt_delete.USEStyleColors = true;
            this.mt_delete.UseTileImage = true;
            // 
            // mt_update
            // 
            this.mt_update.ActiveControl = null;
            this.mt_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.mt_update.Location = new System.Drawing.Point(26, 163);
            this.mt_update.Margin = new System.Windows.Forms.Padding(4);
            this.mt_update.Name = "mt_update";
            this.mt_update.Size = new System.Drawing.Size(189, 71);
            this.mt_update.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt_update.TabIndex = 1;
            this.mt_update.Text = "Update Record";
            this.mt_update.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_update.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_update.TileImage")));
            this.mt_update.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mt_update.UseCustomBackColor = true;
            this.mt_update.UseCustomForeColor = true;
            this.mt_update.UseMnemonic = false;
            this.mt_update.USESelectable = true;
            this.mt_update.USEStyleColors = true;
            this.mt_update.UseTileImage = true;
            // 
            // mt_add
            // 
            this.mt_add.ActiveControl = null;
            this.mt_add.BackColor = System.Drawing.Color.MediumPurple;
            this.mt_add.Location = new System.Drawing.Point(26, 79);
            this.mt_add.Margin = new System.Windows.Forms.Padding(4);
            this.mt_add.Name = "mt_add";
            this.mt_add.Size = new System.Drawing.Size(189, 73);
            this.mt_add.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt_add.TabIndex = 0;
            this.mt_add.Text = "Add Single Record";
            this.mt_add.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_add.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_add.TileImage")));
            this.mt_add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mt_add.UseCustomBackColor = true;
            this.mt_add.UseCustomForeColor = true;
            this.mt_add.UseMnemonic = false;
            this.mt_add.USESelectable = true;
            this.mt_add.USEStyleColors = true;
            this.mt_add.UseTileImage = true;
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Pnl_Header.Controls.Add(this.mlbl_header);
            this.Pnl_Header.HorizontalScrollbarBarColor = true;
            this.Pnl_Header.HorizontalScrollbarHighlightOnWheel = false;
            this.Pnl_Header.HorizontalScrollbarSize = 10;
            this.Pnl_Header.Location = new System.Drawing.Point(-1, -3);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(619, 49);
            this.Pnl_Header.TabIndex = 4;
            this.Pnl_Header.UseCustomBackColor = true;
            this.Pnl_Header.UseCustomForeColor = true;
            this.Pnl_Header.USEStyleColors = true;
            this.Pnl_Header.VerticalScrollbarBarColor = true;
            this.Pnl_Header.VerticalScrollbarHighlightOnWheel = false;
            this.Pnl_Header.VerticalScrollbarSize = 10;
            // 
            // mlbl_header
            // 
            this.mlbl_header.AutoSize = true;
            this.mlbl_header.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mlbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mlbl_header.Location = new System.Drawing.Point(155, 12);
            this.mlbl_header.Name = "mlbl_header";
            this.mlbl_header.Size = new System.Drawing.Size(235, 25);
            this.mlbl_header.TabIndex = 2;
            this.mlbl_header.Text = "Please Select Any Option";
            this.mlbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mt_addMultiple
            // 
            this.mt_addMultiple.ActiveControl = null;
            this.mt_addMultiple.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mt_addMultiple.Location = new System.Drawing.Point(313, 79);
            this.mt_addMultiple.Name = "mt_addMultiple";
            this.mt_addMultiple.Size = new System.Drawing.Size(189, 73);
            this.mt_addMultiple.TabIndex = 5;
            this.mt_addMultiple.Text = "Add Multiple ";
            this.mt_addMultiple.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_addMultiple.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_addMultiple.TileImage")));
            this.mt_addMultiple.UseCustomBackColor = true;
            this.mt_addMultiple.UseCustomForeColor = true;
            this.mt_addMultiple.UseMnemonic = false;
            this.mt_addMultiple.USESelectable = true;
            this.mt_addMultiple.USEStyleColors = true;
            this.mt_addMultiple.UseTileImage = true;
            // 
            // mt_UpdateMultipe
            // 
            this.mt_UpdateMultipe.ActiveControl = null;
            this.mt_UpdateMultipe.BackColor = System.Drawing.Color.DodgerBlue;
            this.mt_UpdateMultipe.Location = new System.Drawing.Point(313, 163);
            this.mt_UpdateMultipe.Name = "mt_UpdateMultipe";
            this.mt_UpdateMultipe.Size = new System.Drawing.Size(189, 71);
            this.mt_UpdateMultipe.TabIndex = 6;
            this.mt_UpdateMultipe.Text = "Update Multiple";
            this.mt_UpdateMultipe.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_UpdateMultipe.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_UpdateMultipe.TileImage")));
            this.mt_UpdateMultipe.UseCustomBackColor = true;
            this.mt_UpdateMultipe.UseCustomForeColor = true;
            this.mt_UpdateMultipe.UseMnemonic = false;
            this.mt_UpdateMultipe.USESelectable = true;
            this.mt_UpdateMultipe.USEStyleColors = true;
            this.mt_UpdateMultipe.UseTileImage = true;
            // 
            // mt_DeleteMultiple
            // 
            this.mt_DeleteMultiple.ActiveControl = null;
            this.mt_DeleteMultiple.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mt_DeleteMultiple.Location = new System.Drawing.Point(313, 248);
            this.mt_DeleteMultiple.Name = "mt_DeleteMultiple";
            this.mt_DeleteMultiple.Size = new System.Drawing.Size(189, 73);
            this.mt_DeleteMultiple.TabIndex = 7;
            this.mt_DeleteMultiple.Text = "Delete Multiple";
            this.mt_DeleteMultiple.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mt_DeleteMultiple.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_DeleteMultiple.TileImage")));
            this.mt_DeleteMultiple.UseCustomBackColor = true;
            this.mt_DeleteMultiple.UseCustomForeColor = true;
            this.mt_DeleteMultiple.UseMnemonic = false;
            this.mt_DeleteMultiple.USESelectable = true;
            this.mt_DeleteMultiple.USEStyleColors = true;
            this.mt_DeleteMultiple.UseTileImage = true;
            // 
            // OPtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(614, 447);
            this.ControlBox = false;
            this.Controls.Add(this.mt_DeleteMultiple);
            this.Controls.Add(this.mt_UpdateMultipe);
            this.Controls.Add(this.mt_addMultiple);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.mt_close);
            this.Controls.Add(this.mt_delete);
            this.Controls.Add(this.mt_update);
            this.Controls.Add(this.mt_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OPtion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Any Option";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt_add;
        private MetroFramework.Controls.MetroTile mt_update;
        private MetroFramework.Controls.MetroTile mt_delete;
        private MetroFramework.Controls.MetroTile mt_close;
        private MetroFramework.Controls.MetroPanel Pnl_Header;
        private System.Windows.Forms.Label mlbl_header;
        private MetroFramework.Controls.MetroTile mt_addMultiple;
        private MetroFramework.Controls.MetroTile mt_UpdateMultipe;
        private MetroFramework.Controls.MetroTile mt_DeleteMultiple;
    }
}