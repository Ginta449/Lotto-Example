namespace DeirdreAndGintaCA
{
    partial class Form1
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
            this.btnQuickPick = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.lstQuickPick = new System.Windows.Forms.ListBox();
            this.lstSort = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuickPick
            // 
            this.btnQuickPick.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuickPick.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickPick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuickPick.Location = new System.Drawing.Point(50, 14);
            this.btnQuickPick.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuickPick.Name = "btnQuickPick";
            this.btnQuickPick.Size = new System.Drawing.Size(107, 68);
            this.btnQuickPick.TabIndex = 0;
            this.btnQuickPick.Text = "Quick Pick";
            this.btnQuickPick.UseVisualStyleBackColor = false;
            this.btnQuickPick.Click += new System.EventHandler(this.btnQuickPick_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(142, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstQuickPick
            // 
            this.lstQuickPick.FormattingEnabled = true;
            this.lstQuickPick.ItemHeight = 16;
            this.lstQuickPick.Location = new System.Drawing.Point(50, 90);
            this.lstQuickPick.Name = "lstQuickPick";
            this.lstQuickPick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstQuickPick.Size = new System.Drawing.Size(107, 244);
            this.lstQuickPick.TabIndex = 3;
            // 
            // lstSort
            // 
            this.lstSort.FormattingEnabled = true;
            this.lstSort.ItemHeight = 16;
            this.lstSort.Location = new System.Drawing.Point(234, 90);
            this.lstSort.Name = "lstSort";
            this.lstSort.Size = new System.Drawing.Size(101, 244);
            this.lstSort.TabIndex = 4;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSort.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Location = new System.Drawing.Point(228, 14);
            this.btnSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(107, 68);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstSort);
            this.Controls.Add(this.lstQuickPick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuickPick);
            this.Name = "Form1";
            this.Text = "Lotto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuickPick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstQuickPick;
        private System.Windows.Forms.ListBox lstSort;
        private System.Windows.Forms.Button btnSort;
    }
}

