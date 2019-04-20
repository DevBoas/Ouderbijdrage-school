namespace Ouderbijdrage_school
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
            this.OuderStatus = new System.Windows.Forms.CheckBox();
            this.Voegtoe = new System.Windows.Forms.Button();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OuderStatus
            // 
            this.OuderStatus.AutoSize = true;
            this.OuderStatus.Location = new System.Drawing.Point(83, 96);
            this.OuderStatus.Name = "OuderStatus";
            this.OuderStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OuderStatus.Size = new System.Drawing.Size(96, 17);
            this.OuderStatus.TabIndex = 4;
            this.OuderStatus.Text = "éénoudergezin";
            this.OuderStatus.UseVisualStyleBackColor = true;
            // 
            // Voegtoe
            // 
            this.Voegtoe.Location = new System.Drawing.Point(83, 67);
            this.Voegtoe.Name = "Voegtoe";
            this.Voegtoe.Size = new System.Drawing.Size(96, 23);
            this.Voegtoe.TabIndex = 5;
            this.Voegtoe.Text = "Voeg kind toe";
            this.Voegtoe.UseVisualStyleBackColor = true;
            this.Voegtoe.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(83, 114);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(96, 23);
            this.Bereken.TabIndex = 6;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(80, 140);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(76, 13);
            this.Output.TabIndex = 7;
            this.Output.Text = "Ouderbijdrage:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 172);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.Voegtoe);
            this.Controls.Add(this.OuderStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Ouderbijdrage school";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OuderStatus;
        private System.Windows.Forms.Button Voegtoe;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
    }
}

