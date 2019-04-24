using System;
using System.Windows.Forms;

namespace JustAWinForm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void OnClick_btnConvertToUpper(object sender, EventArgs e)
        {
            ConvertContentToUpperCase();
            ResendTheFocusToTheTextBox();
        }

        private void ResendTheFocusToTheTextBox()
        {
            txtTextToConvert.Focus();
            txtTextToConvert.Select(txtTextToConvert.Text.Length, 0);
        }

        private void ConvertContentToUpperCase()
        {
            txtTextToConvert.Text = txtTextToConvert.Text.ToUpper();
        }

        private void OnClick_btnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
