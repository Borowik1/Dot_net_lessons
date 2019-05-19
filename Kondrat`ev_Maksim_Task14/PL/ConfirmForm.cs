using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm(Award award)
        {
            InitializeComponent();
            lblConfirmText.Text = $"Удалить награду '{award.AwardName}'?";
        }

        public ConfirmForm(User user)
        {
            InitializeComponent();
            lblConfirmText.Text = $"Удалить пользователя '{user.LastName} {user.FirstName}'?";
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
