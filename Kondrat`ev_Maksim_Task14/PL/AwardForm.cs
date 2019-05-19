using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace PL
{
    public partial class AwardForm : Form
    {
        bool newAward = true;
        string name;
        string desc;
        public string AwardName { get => name; set => name = value; }
        public string AwardDesc { get => desc; set => desc = value; }

        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Award award)
        {
            newAward = false;
            AwardName = award.AwardName;
            AwardDesc = award.AwardDescription;
            InitializeComponent();
        }

        private void AwardForm_Load(object sender, EventArgs e)
        {
            if (newAward)
            {
                Text = "Добавить награду";
                btnOk.Text = "Готово";
            }
            else
            {
                Text = "Изменить награду";
                btnOk.Text = "Изменить";
                tbAwardName.Text = name;
                tbAwardDesc.Text = desc;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbAwardName_Validating(object sender, CancelEventArgs e)
        {
            if(tbAwardName.Text.Length<51 & tbAwardName.Text.Length > 0)
            {
                erTextAwardName.SetError(this.tbAwardName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                erTextAwardName.SetError(this.tbAwardName, "Ошибка");
                e.Cancel = true;
            }
        }

        private void TbAwardName_Validated(object sender, EventArgs e)
        {
            AwardName = tbAwardName.Text;
        }

        private void TbAwardDesc_Validating(object sender, CancelEventArgs e)
        {
            if (tbAwardDesc.Text.Length < 150)
            {
                erTextAwardDesc.SetError(this.tbAwardDesc, string.Empty);
                e.Cancel = false;
            }
            else
            {
                erTextAwardDesc.SetError(this.tbAwardDesc, "Ошибка");
                e.Cancel = true;
            }
        }

        private void TbAwardDesc_Validated(object sender, EventArgs e)
        {
            AwardDesc = tbAwardDesc.Text;
        }
    }
}
