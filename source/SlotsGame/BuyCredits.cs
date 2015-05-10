using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsGame
{

    public partial class BuyCredits : Form
    {
        public float Result;
        public BuyCredits()
        {
            InitializeComponent();
            Result = 0;
        }

      

        private void btnProceed_Click(object sender, EventArgs e)
        {
            float moreBalance;
            float.TryParse(tbCredits.Text, out moreBalance);
            if (tbCredits.Text.Trim().Length != 0 && moreBalance >= 1)
            {
                Result = moreBalance;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.creditInputErrorProvider.SetError(btnProceed, "You must buy credits in order to proceed");
            }


        }
        private void tbCredits_Validating(object sender, CancelEventArgs e)
        {

            if (tbCredits.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                creditInputErrorProvider.SetError(tbCredits, "Please select how much credits you want to buy.");
            }
            else
            {
                float f;
                float.TryParse(tbCredits.Text, out f);
                if (f < 1)
                {
                    e.Cancel = true;
                    creditInputErrorProvider.SetError(tbCredits, "Select a number larger than 0, and no letters!");
                }
                else
                {
                    string number = tbCredits.Text;
                    char[] digits = number.ToCharArray();
                    bool isDig = true;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (!Char.IsDigit(digits[i]))
                        {
                            isDig = false;
                            break;

                        }
                    }

                    if (!isDig)
                    {
                        e.Cancel = true;
                        creditInputErrorProvider.SetError(tbCredits, "Please only input numbers");
                    }
                    else
                    {

                        e.Cancel = false;
                        creditInputErrorProvider.SetError(tbCredits, null);

                    }
                }
            }
        }

    }
}