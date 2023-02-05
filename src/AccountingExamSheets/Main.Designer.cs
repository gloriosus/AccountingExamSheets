namespace AccountingExamSheets
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ActionsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.AddListTS = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartTS = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTS = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTS = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTS = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ListsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ElementsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTS = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoTS = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.AddListDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintFormatDownTS = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionsTS,
            this.SettingsTS,
            this.журналToolStripMenuItem,
            this.InfoTS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ActionsTS
            // 
            this.ActionsTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddListTS,
            this.ChangeTS,
            this.DeleteTS,
            this.PrintTS,
            this.toolStripSeparator1,
            this.ExitTS});
            this.ActionsTS.Name = "ActionsTS";
            this.ActionsTS.Size = new System.Drawing.Size(70, 20);
            this.ActionsTS.Text = "Действия";
            // 
            // AddListTS
            // 
            this.AddListTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandartTS,
            this.MasterTS});
            this.AddListTS.Image = global::AccountingExamSheets.Properties.Resources.add;
            this.AddListTS.Name = "AddListTS";
            this.AddListTS.Size = new System.Drawing.Size(171, 22);
            this.AddListTS.Text = "Добавить лист";
            // 
            // StandartTS
            // 
            this.StandartTS.Name = "StandartTS";
            this.StandartTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.StandartTS.Size = new System.Drawing.Size(231, 22);
            this.StandartTS.Text = "Стандартный режим";
            this.StandartTS.Click += new System.EventHandler(this.StandartTS_Click);
            // 
            // MasterTS
            // 
            this.MasterTS.Name = "MasterTS";
            this.MasterTS.Size = new System.Drawing.Size(231, 22);
            this.MasterTS.Text = "Режим мастера";
            // 
            // ChangeTS
            // 
            this.ChangeTS.Image = global::AccountingExamSheets.Properties.Resources.edit;
            this.ChangeTS.Name = "ChangeTS";
            this.ChangeTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ChangeTS.Size = new System.Drawing.Size(171, 22);
            this.ChangeTS.Text = "Изменить";
            this.ChangeTS.Click += new System.EventHandler(this.ChangeTS_Click);
            // 
            // DeleteTS
            // 
            this.DeleteTS.Image = global::AccountingExamSheets.Properties.Resources.delete;
            this.DeleteTS.Name = "DeleteTS";
            this.DeleteTS.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteTS.Size = new System.Drawing.Size(171, 22);
            this.DeleteTS.Text = "Удалить";
            this.DeleteTS.Click += new System.EventHandler(this.DeleteTS_Click);
            // 
            // PrintTS
            // 
            this.PrintTS.Image = global::AccountingExamSheets.Properties.Resources.print;
            this.PrintTS.Name = "PrintTS";
            this.PrintTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintTS.Size = new System.Drawing.Size(171, 22);
            this.PrintTS.Text = "Печать";
            this.PrintTS.Click += new System.EventHandler(this.PrintTS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // ExitTS
            // 
            this.ExitTS.Name = "ExitTS";
            this.ExitTS.Size = new System.Drawing.Size(171, 22);
            this.ExitTS.Text = "Выход";
            this.ExitTS.Click += new System.EventHandler(this.ExitTS_Click);
            // 
            // SettingsTS
            // 
            this.SettingsTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListsTS,
            this.ElementsTS});
            this.SettingsTS.Name = "SettingsTS";
            this.SettingsTS.Size = new System.Drawing.Size(79, 20);
            this.SettingsTS.Text = "Настройки";
            // 
            // ListsTS
            // 
            this.ListsTS.Image = global::AccountingExamSheets.Properties.Resources.lists;
            this.ListsTS.Name = "ListsTS";
            this.ListsTS.Size = new System.Drawing.Size(154, 22);
            this.ListsTS.Text = "Списки";
            this.ListsTS.Click += new System.EventHandler(this.ListsTS_Click);
            // 
            // ElementsTS
            // 
            this.ElementsTS.Image = global::AccountingExamSheets.Properties.Resources._default;
            this.ElementsTS.Name = "ElementsTS";
            this.ElementsTS.Size = new System.Drawing.Size(154, 22);
            this.ElementsTS.Text = "Предпочтения";
            this.ElementsTS.Click += new System.EventHandler(this.ElementsTS_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTS});
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.журналToolStripMenuItem.Text = "Журнал";
            // 
            // OpenTS
            // 
            this.OpenTS.Name = "OpenTS";
            this.OpenTS.Size = new System.Drawing.Size(121, 22);
            this.OpenTS.Text = "Открыть";
            this.OpenTS.Click += new System.EventHandler(this.OpenTS_Click);
            // 
            // InfoTS
            // 
            this.InfoTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpTS,
            this.toolStripSeparator2,
            this.AboutTS});
            this.InfoTS.Name = "InfoTS";
            this.InfoTS.Size = new System.Drawing.Size(65, 20);
            this.InfoTS.Text = "Справка";
            // 
            // HelpTS
            // 
            this.HelpTS.Image = global::AccountingExamSheets.Properties.Resources.help;
            this.HelpTS.Name = "HelpTS";
            this.HelpTS.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpTS.Size = new System.Drawing.Size(149, 22);
            this.HelpTS.Text = "Помощь";
            this.HelpTS.Click += new System.EventHandler(this.HelpTS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // AboutTS
            // 
            this.AboutTS.Image = global::AccountingExamSheets.Properties.Resources.about;
            this.AboutTS.Name = "AboutTS";
            this.AboutTS.Size = new System.Drawing.Size(149, 22);
            this.AboutTS.Text = "О программе";
            this.AboutTS.Click += new System.EventHandler(this.AboutTS_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddListDownTS,
            this.EditDownTS,
            this.DeleteDownTS,
            this.PrintDownTS,
            this.toolStripMenuItem1,
            this.PrintFormatDownTS});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(619, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // AddListDownTS
            // 
            this.AddListDownTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandartDownTS,
            this.MasterDownTS});
            this.AddListDownTS.Image = global::AccountingExamSheets.Properties.Resources.add;
            this.AddListDownTS.Name = "AddListDownTS";
            this.AddListDownTS.Size = new System.Drawing.Size(28, 20);
            this.AddListDownTS.ToolTipText = "Добавить лист";
            // 
            // StandartDownTS
            // 
            this.StandartDownTS.Name = "StandartDownTS";
            this.StandartDownTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.StandartDownTS.Size = new System.Drawing.Size(231, 22);
            this.StandartDownTS.Text = "Стандартный режим";
            this.StandartDownTS.Click += new System.EventHandler(this.StandartDownTS_Click);
            // 
            // MasterDownTS
            // 
            this.MasterDownTS.Name = "MasterDownTS";
            this.MasterDownTS.Size = new System.Drawing.Size(231, 22);
            this.MasterDownTS.Text = "Режим мастера";
            // 
            // EditDownTS
            // 
            this.EditDownTS.Image = global::AccountingExamSheets.Properties.Resources.edit;
            this.EditDownTS.Name = "EditDownTS";
            this.EditDownTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.EditDownTS.ShowShortcutKeys = false;
            this.EditDownTS.Size = new System.Drawing.Size(28, 20);
            this.EditDownTS.ToolTipText = "Изменить";
            this.EditDownTS.Click += new System.EventHandler(this.EditDownTS_Click);
            // 
            // DeleteDownTS
            // 
            this.DeleteDownTS.Image = global::AccountingExamSheets.Properties.Resources.delete;
            this.DeleteDownTS.Name = "DeleteDownTS";
            this.DeleteDownTS.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteDownTS.ShowShortcutKeys = false;
            this.DeleteDownTS.Size = new System.Drawing.Size(28, 20);
            this.DeleteDownTS.ToolTipText = "Удалить";
            this.DeleteDownTS.Click += new System.EventHandler(this.DeleteDownTS_Click);
            // 
            // PrintDownTS
            // 
            this.PrintDownTS.Image = global::AccountingExamSheets.Properties.Resources.print;
            this.PrintDownTS.Name = "PrintDownTS";
            this.PrintDownTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintDownTS.ShowShortcutKeys = false;
            this.PrintDownTS.Size = new System.Drawing.Size(28, 20);
            this.PrintDownTS.ToolTipText = "Печать";
            this.PrintDownTS.Click += new System.EventHandler(this.PrintDownTS_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // PrintFormatDownTS
            // 
            this.PrintFormatDownTS.Image = global::AccountingExamSheets.Properties.Resources.printsettings;
            this.PrintFormatDownTS.Name = "PrintFormatDownTS";
            this.PrintFormatDownTS.Size = new System.Drawing.Size(28, 20);
            this.PrintFormatDownTS.ToolTipText = "Печать с выбором формата";
            this.PrintFormatDownTS.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(297, 210);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(309, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(297, 210);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.Color.White;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.checkBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(12, 261);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(297, 210);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.Color.White;
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.checkBox4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(309, 261);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(297, 210);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckStateChanged);
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackColor = System.Drawing.Color.White;
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Location = new System.Drawing.Point(12, 51);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(594, 420);
            this.PreviewBox.TabIndex = 7;
            this.PreviewBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 483);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обозреватель экзаменационных листов";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ActionsTS;
        private System.Windows.Forms.ToolStripMenuItem AddListTS;
        private System.Windows.Forms.ToolStripMenuItem StandartTS;
        private System.Windows.Forms.ToolStripMenuItem MasterTS;
        private System.Windows.Forms.ToolStripMenuItem ChangeTS;
        private System.Windows.Forms.ToolStripMenuItem DeleteTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitTS;
        private System.Windows.Forms.ToolStripMenuItem PrintTS;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem AddListDownTS;
        private System.Windows.Forms.ToolStripMenuItem EditDownTS;
        private System.Windows.Forms.ToolStripMenuItem DeleteDownTS;
        private System.Windows.Forms.ToolStripMenuItem PrintDownTS;
        private System.Windows.Forms.ToolStripMenuItem StandartDownTS;
        private System.Windows.Forms.ToolStripMenuItem MasterDownTS;
        private System.Windows.Forms.ToolStripMenuItem SettingsTS;
        private System.Windows.Forms.ToolStripMenuItem InfoTS;
        private System.Windows.Forms.ToolStripMenuItem HelpTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AboutTS;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ListsTS;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTS;
        private System.Windows.Forms.ToolStripMenuItem ElementsTS;
        private System.Windows.Forms.ToolStripMenuItem PrintFormatDownTS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}