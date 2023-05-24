namespace WindowsFormsAppBefiz
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
            this.InputWindowa = new System.Windows.Forms.GroupBox();
            this.befizAzonText = new System.Windows.Forms.TextBox();
            this.befitzOsszegText = new System.Windows.Forms.TextBox();
            this.befizSubmit = new System.Windows.Forms.Button();
            this.befizDate = new System.Windows.Forms.Label();
            this.befizAzon = new System.Windows.Forms.Label();
            this.befizOsszeg = new System.Windows.Forms.Label();
            this.befizDatumText = new System.Windows.Forms.DateTimePicker();
            this.dbConetents = new System.Windows.Forms.ListBox();
            this.InputWindowa.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputWindowa
            // 
            this.InputWindowa.Controls.Add(this.befizAzonText);
            this.InputWindowa.Controls.Add(this.befitzOsszegText);
            this.InputWindowa.Controls.Add(this.befizSubmit);
            this.InputWindowa.Controls.Add(this.befizDate);
            this.InputWindowa.Controls.Add(this.befizAzon);
            this.InputWindowa.Controls.Add(this.befizOsszeg);
            this.InputWindowa.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputWindowa.Location = new System.Drawing.Point(0, 0);
            this.InputWindowa.Name = "InputWindowa";
            this.InputWindowa.Size = new System.Drawing.Size(487, 450);
            this.InputWindowa.TabIndex = 1;
            this.InputWindowa.TabStop = false;
            this.InputWindowa.Text = "Adatbáziban író";
            this.InputWindowa.Enter += new System.EventHandler(this.dbContent_Enter);
            // 
            // befizAzonText
            // 
            this.befizAzonText.Location = new System.Drawing.Point(164, 38);
            this.befizAzonText.Name = "befizAzonText";
            this.befizAzonText.Size = new System.Drawing.Size(200, 20);
            this.befizAzonText.TabIndex = 3;
            // 
            // befitzOsszegText
            // 
            this.befitzOsszegText.Location = new System.Drawing.Point(164, 84);
            this.befitzOsszegText.Name = "befitzOsszegText";
            this.befitzOsszegText.Size = new System.Drawing.Size(200, 20);
            this.befitzOsszegText.TabIndex = 4;
            // 
            // befizSubmit
            // 
            this.befizSubmit.Location = new System.Drawing.Point(164, 176);
            this.befizSubmit.Name = "befizSubmit";
            this.befizSubmit.Size = new System.Drawing.Size(75, 23);
            this.befizSubmit.TabIndex = 2;
            this.befizSubmit.Text = "Beadás";
            this.befizSubmit.UseVisualStyleBackColor = true;
            this.befizSubmit.Click += new System.EventHandler(this.befizSubmit_Click);
            // 
            // befizDate
            // 
            this.befizDate.AutoSize = true;
            this.befizDate.Location = new System.Drawing.Point(29, 132);
            this.befizDate.Name = "befizDate";
            this.befizDate.Size = new System.Drawing.Size(41, 13);
            this.befizDate.TabIndex = 8;
            this.befizDate.Text = "Dátum:";
            // 
            // befizAzon
            // 
            this.befizAzon.AutoSize = true;
            this.befizAzon.Location = new System.Drawing.Point(29, 45);
            this.befizAzon.Name = "befizAzon";
            this.befizAzon.Size = new System.Drawing.Size(74, 13);
            this.befizAzon.TabIndex = 6;
            this.befizAzon.Text = "Befizető azon:";
            // 
            // befizOsszeg
            // 
            this.befizOsszeg.AutoSize = true;
            this.befizOsszeg.Location = new System.Drawing.Point(29, 84);
            this.befizOsszeg.Name = "befizOsszeg";
            this.befizOsszeg.Size = new System.Drawing.Size(104, 13);
            this.befizOsszeg.TabIndex = 7;
            this.befizOsszeg.Text = "Bezizetendő ősszeg:";
            // 
            // befizDatumText
            // 
            this.befizDatumText.Location = new System.Drawing.Point(164, 132);
            this.befizDatumText.Name = "befizDatumText";
            this.befizDatumText.Size = new System.Drawing.Size(200, 20);
            this.befizDatumText.TabIndex = 5;
            // 
            // dbConetents
            // 
            this.dbConetents.Dock = System.Windows.Forms.DockStyle.Right;
            this.dbConetents.FormattingEnabled = true;
            this.dbConetents.Location = new System.Drawing.Point(493, 0);
            this.dbConetents.Name = "dbConetents";
            this.dbConetents.Size = new System.Drawing.Size(307, 450);
            this.dbConetents.TabIndex = 6;
            this.dbConetents.SelectedIndexChanged += new System.EventHandler(this.dbConetents_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbConetents);
            this.Controls.Add(this.befizDatumText);
            this.Controls.Add(this.InputWindowa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputWindowa.ResumeLayout(false);
            this.InputWindowa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox InputWindowa;
        private System.Windows.Forms.Button befizSubmit;
        private System.Windows.Forms.TextBox befizAzonText;
        private System.Windows.Forms.TextBox befitzOsszegText;
        private System.Windows.Forms.DateTimePicker befizDatumText;
        private System.Windows.Forms.Label befizAzon;
        private System.Windows.Forms.Label befizOsszeg;
        private System.Windows.Forms.Label befizDate;
        private System.Windows.Forms.ListBox dbConetents;
    }
}

