namespace EntityFrmMSAccess
{
    partial class frmEnterText
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
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.txtNodeName = new MetroFramework.Controls.MetroTextBox();
            this.txtNodeLstName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(227, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // txtNodeName
            // 
            // 
            // 
            // 
            this.txtNodeName.CustomButton.Image = null;
            this.txtNodeName.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtNodeName.CustomButton.Name = "";
            this.txtNodeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNodeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNodeName.CustomButton.TabIndex = 1;
            this.txtNodeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNodeName.CustomButton.UseSelectable = true;
            this.txtNodeName.CustomButton.Visible = false;
            this.txtNodeName.Lines = new string[0];
            this.txtNodeName.Location = new System.Drawing.Point(137, 63);
            this.txtNodeName.MaxLength = 32767;
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.PasswordChar = '\0';
            this.txtNodeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNodeName.SelectedText = "";
            this.txtNodeName.SelectionLength = 0;
            this.txtNodeName.SelectionStart = 0;
            this.txtNodeName.ShortcutsEnabled = true;
            this.txtNodeName.Size = new System.Drawing.Size(124, 23);
            this.txtNodeName.TabIndex = 8;
            this.txtNodeName.UseSelectable = true;
            this.txtNodeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNodeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNodeLstName
            // 
            // 
            // 
            // 
            this.txtNodeLstName.CustomButton.Image = null;
            this.txtNodeLstName.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtNodeLstName.CustomButton.Name = "";
            this.txtNodeLstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNodeLstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNodeLstName.CustomButton.TabIndex = 1;
            this.txtNodeLstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNodeLstName.CustomButton.UseSelectable = true;
            this.txtNodeLstName.CustomButton.Visible = false;
            this.txtNodeLstName.Lines = new string[0];
            this.txtNodeLstName.Location = new System.Drawing.Point(356, 63);
            this.txtNodeLstName.MaxLength = 32767;
            this.txtNodeLstName.Name = "txtNodeLstName";
            this.txtNodeLstName.PasswordChar = '\0';
            this.txtNodeLstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNodeLstName.SelectedText = "";
            this.txtNodeLstName.SelectionLength = 0;
            this.txtNodeLstName.SelectionStart = 0;
            this.txtNodeLstName.ShortcutsEnabled = true;
            this.txtNodeLstName.Size = new System.Drawing.Size(124, 23);
            this.txtNodeLstName.TabIndex = 9;
            this.txtNodeLstName.UseSelectable = true;
            this.txtNodeLstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNodeLstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(276, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(74, 19);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Location = new System.Drawing.Point(137, 92);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 29);
            this.cmbGender.TabIndex = 12;
            this.cmbGender.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Gender:";
            // 
            // frmEnterText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 176);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNodeLstName);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.btnOk);
            this.Name = "frmEnterText";
            this.Text = "Update Node";
            this.Load += new System.EventHandler(this.frmEnterText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroTextBox txtNodeName;
        private MetroFramework.Controls.MetroTextBox txtNodeLstName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}