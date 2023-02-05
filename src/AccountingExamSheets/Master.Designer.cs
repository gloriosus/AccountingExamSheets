namespace AccountingExamSheets
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.Greetings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greetings.Location = new System.Drawing.Point(12, 9);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(554, 42);
            this.Greetings.TabIndex = 1;
            this.Greetings.Text = "Вас приветствует мастер создания экзаменационных листов! \r\nПожалуйста проследуйте" +
    " приведенным инструкциям и заполните все поля.";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 359);
            this.Controls.Add(this.Greetings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Master";
            this.Text = "Мастер создания экзаменационных листов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greetings;
    }
}