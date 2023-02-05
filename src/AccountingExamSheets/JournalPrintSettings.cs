using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    public partial class JournalPrintSettings : Form
    {
        public JournalPrintSettings()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioPrintRange_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPrintRange.Checked)
            {
                NumericFrom.Enabled = true;
                NumericTo.Enabled = true;
            }
            else if (!RadioPrintRange.Checked)
            {
                NumericFrom.Enabled = false;
                NumericTo.Enabled = false;
            }
        }

        private void NumericFrom_ValueChanged(object sender, EventArgs e)
        {
            if (NumericFrom.Value > NumericTo.Value)
            {
                NumericTo.Value = NumericFrom.Value;
            }
        }

        private void NumericTo_ValueChanged(object sender, EventArgs e)
        {
            if (NumericTo.Value < NumericFrom.Value)
            {
                NumericFrom.Value = NumericTo.Value;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            PrintJournal Print = new PrintJournal();

            if (RadioPrintAll.Checked)
            {
                Print.PrintOut();
            }
            else if (RadioPrintCurrent.Checked)
            {
                Journal journal = this.Owner as Journal;

                if (journal != null)
                {
                    Print.PrintOut(journal.CurrentPage);
                }
            }
            else if (RadioPrintRange.Checked)
            {
                Print.PrintOut(Convert.ToInt32(NumericFrom.Value), Convert.ToInt32(NumericTo.Value));
            }

            Close();
        }
    }
}
