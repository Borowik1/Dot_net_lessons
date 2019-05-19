using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entities;

namespace PL
{
    public partial class UserForm : Form
    {
        private bool newUser = true;
        public static List<Award> listOfUserAwards = new List<Award>();
        public static List<Award> listOfAwards = new List<Award>();
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Award> ListOfAwards
        {
            get
            {
                return listOfUserAwards;
            }
        }
        public UserForm(IEnumerable<Award> listOfAw)
        {
            InitializeComponent();
            foreach(Award award in listOfAw)
            {
                clbUsersAwards.Items.Add(award.AwardName);
            }
            listOfAwards.AddRange(listOfAw);
            clbUsersAwards.CheckOnClick = true;
        }
        public UserForm(User user, IEnumerable<Award> listOfAw)
        {
            newUser = false;
            InitializeComponent();
            clbUsersAwards.CheckOnClick = true;
            foreach (Award award in listOfAw)
            {
                clbUsersAwards.Items.Add(award.AwardName, user.Awards.Contains(award));
            }
            listOfAwards.AddRange(listOfAw);
            LastName = user.LastName;
            FirstName = user.FirstName;
            DateOfBirth = user.DateOfBirth;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            listOfUserAwards.Clear();

            for (int i = 0; i < clbUsersAwards.CheckedItems.Count; i++)
            {
                foreach(Award award in listOfAwards)
                {
                    if (award.AwardName == clbUsersAwards.CheckedItems[i].ToString())
                    {
                        listOfUserAwards.Add(award);
                    }
                }
                
            }

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
        private void TextLastName_Validated(object sender, EventArgs e)
        {
            this.LastName = FormateName(textLastName.Text);
        }
        private void TextLastName_Validating(object sender, CancelEventArgs e)
        {
            if (textLastName.Text.Length > 0 & TextNameValid(textLastName.Text))
            {
                erTextLastName.SetError(this.textLastName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                erTextLastName.SetError(this.textLastName, "Недопустимые символы");
                e.Cancel = true;
            }
        }
        private bool TextNameValid(string txt)
        {
            return Regex.IsMatch(txt, @"^[а-я,А-Я,ё,Ё]*$");
        }
        private string FormateName(string txt)
        {
            char[] res = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                if (i == 0)
                {
                    res[i] = Char.ToUpper(txt[i]);
                }
                else
                {
                    res[i] = Char.ToLower(txt[i]);
                }
            }
            return new string(res);
        }
        private void TextFirstName_Validated(object sender, EventArgs e)
        {
            this.FirstName = FormateName(textFirstName.Text);
        }
        private void TextFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (textFirstName.Text.Length > 0 & TextNameValid(textFirstName.Text))
            {
                erTextFirstName.SetError(this.textFirstName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                erTextFirstName.SetError(this.textFirstName, "Недопустимые символы");
                e.Cancel = true;
            }
        }
        private void DateDateOfBirth_Validated(object sender, EventArgs e)
        {
            this.DateOfBirth = dateDateOfBirth.Value;
        }
        private void DateDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (this.dateDateOfBirth.Value.Year > DateTime.Now.Year - 150
                & this.dateDateOfBirth.Value.Year < DateTime.Now.Year - 10)
            {
                erTextFirstName.SetError(this.dateDateOfBirth, string.Empty);
                e.Cancel = false;
            }
            else
            {
                erTextFirstName.SetError(this.dateDateOfBirth, "Недопустимый возраст");
                e.Cancel = true;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            textFirstName.Text = FirstName;
            textLastName.Text = LastName;
            dateDateOfBirth.Text = DateOfBirth.ToString();

            if (newUser)
            {
                Text = "Добавление нового пользователя";
                btnOk.Text = "Создать";
            }
            else
            {
                Text = "Редактирование пользователя";
                btnOk.Text = "Готово";
            }
        }
        public object[] GetArrayOfAwards(List<Award> awards)
        {
            return awards.ToArray<object>();
        }
    }
}