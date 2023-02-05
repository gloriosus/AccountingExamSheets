namespace AccountingExamSheets
{
    partial class JournalPrintSettings
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
            this.RadioPrintAll = new System.Windows.Forms.RadioButton();
            this.RadioPrintCurrent = new System.Windows.Forms.RadioButton();
            this.RadioPrintRange = new System.Windows.Forms.RadioButton();
            this.NumericFrom = new System.Windows.Forms.NumericUpDown();
            this.NumericTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTo)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioPrintAll
            // 
            this.RadioPrintAll.AutoSize = true;
            this.RadioPrintAll.Location = new System.Drawing.Point(12, 12);
            this.RadioPrintAll.Name = "RadioPrintAll";
            this.RadioPrintAll.Size = new System.Drawing.Size(93, 17);
            this.RadioPrintAll.TabIndex = 0;
            this.RadioPrintAll.TabStop = true;
            this.RadioPrintAll.Text = "Печатать все";
            this.RadioPrintAll.UseVisualStyleBackColor = true;
            // 
            // RadioPrintCurrent
            // 
            this.RadioPrintCurrent.AutoSize = true;
            this.RadioPrintCurrent.Location = new System.Drawing.Point(12, 35);
            this.RadioPrintCurrent.Name = "RadioPrintCurrent";
            this.RadioPrintCurrent.Size = new System.Drawing.Size(168, 17);
            this.RadioPrintCurrent.TabIndex = 1;
            this.RadioPrintCurrent.TabStop = true;
            this.RadioPrintCurrent.Text = "Печатать текущую страницу";
            this.RadioPrintCurrent.UseVisualStyleBackColor = true;
            // 
            // RadioPrintRange
            // 
            this.RadioPrintRange.AutoSize = true;
            this.RadioPrintRange.Location = new System.Drawing.Point(12, 58);
            this.RadioPrintRange.Name = "RadioPrintRange";
            this.RadioPrintRange.Size = new System.Drawing.Size(123, 17);
            this.RadioPrintRange.TabIndex = 2;
            this.RadioPrintRange.TabStop = true;
            this.RadioPrintRange.Text = "Печатать диапазон";
            this.RadioPrintRange.UseVisualStyleBackColor = true;
            this.RadioPrintRange.CheckedChanged += new System.EventHandler(this.RadioPrintRange_CheckedChanged);
            // 
            // NumericFrom
            // 
            this.NumericFrom.Enabled = false;
            this.NumericFrom.Location = new System.Drawing.Point(41, 81);
            this.NumericFrom.Name = "NumericFrom";
            this.NumericFrom.Size = new System.Drawing.Size(49, 20);
            this.NumericFrom.TabIndex = 3;
            this.NumericFrom.ValueChanged += new System.EventHandler(this.NumericFrom_ValueChanged);
            // 
            // NumericTo
            // 
            this.NumericTo.Enabled = false;
            this.NumericTo.Location = new System.Drawing.Point(121, 81);
            this.NumericTo.Name = "NumericTo";
            this.NumericTo.Size = new System.Drawing.Size(49, 20);
            this.NumericTo.TabIndex = 4;
            this.NumericTo.ValueChanged += new System.EventHandler(this.NumericTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(201, 118);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(121, 118);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // JournalPrintSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 153);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericTo);
            this.Controls.Add(this.NumericFrom);
            this.Controls.Add(this.RadioPrintRange);
            this.Controls.Add(this.RadioPrintCurrent);
            this.Controls.Add(this.RadioPrintAll);
            this.Name = "JournalPrintSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки печати журнала";
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioPrintAll;
        private System.Windows.Forms.RadioButton RadioPrintCurrent;
        private System.Windows.Forms.RadioButton RadioPrintRange;
        private System.Windows.Forms.NumericUpDown NumericFrom;
        private System.Windows.Forms.NumericUpDown NumericTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}