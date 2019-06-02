namespace APM_WorkingWithFiles
{
    partial class MainForm
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
            this.btn_fileStreamRead = new System.Windows.Forms.Button();
            this.rctxbx_data = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_fileStreamRead
            // 
            this.btn_fileStreamRead.Location = new System.Drawing.Point(13, 394);
            this.btn_fileStreamRead.Name = "btn_fileStreamRead";
            this.btn_fileStreamRead.Size = new System.Drawing.Size(216, 23);
            this.btn_fileStreamRead.TabIndex = 0;
            this.btn_fileStreamRead.Text = "Read using FileStream";
            this.btn_fileStreamRead.UseVisualStyleBackColor = true;
            this.btn_fileStreamRead.Click += new System.EventHandler(this.btn_fileStreamRead_Click);
            // 
            // rctxbx_data
            // 
            this.rctxbx_data.Location = new System.Drawing.Point(13, 13);
            this.rctxbx_data.Name = "rctxbx_data";
            this.rctxbx_data.Size = new System.Drawing.Size(679, 360);
            this.rctxbx_data.TabIndex = 2;
            this.rctxbx_data.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 458);
            this.Controls.Add(this.rctxbx_data);
            this.Controls.Add(this.btn_fileStreamRead);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fileStreamRead;
        private System.Windows.Forms.RichTextBox rctxbx_data;
    }
}

