using UsersAwardsBLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;

namespace UsersAwardsPL
{
    public partial class MainForm : Form
    {
        private readonly UsersBL listOfUsers;
        private readonly AwardsBL listOfAwards;
        private int _userId = 0;
        private int _awardId = 0;
        public MainForm()
        {
            listOfUsers = new UsersBL();
            listOfAwards = new AwardsBL();
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        private void AddUser()
        {
            var form = new UserForm(listOfAwards.GetList());
            if (form.ShowDialog() == DialogResult.OK)
            {
                listOfUsers.Add(new User(_userId, form.FirstName, form.LastName, form.DateOfBirth, form.ListOfAwards));
                DisplayUsers();
            }
        }
        private void EditUser()
        {
            if (ctrGridUser.SelectedCells.Count > 0)
            {
                int id = (int)ctrGridUser.Rows[ctrGridUser.SelectedCells[0].RowIndex].Cells[4].Value;                
                User user = new User();
                foreach (User us in listOfUsers.GetList())
                {
                    if (us.Id == id)
                    {
                        user = us;
                    }
                }

                UserForm form = new UserForm(user, listOfAwards.GetList());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.DateOfBirth = form.DateOfBirth;
                    user.Awards = form.ListOfAwards;
                    listOfUsers.Edit(user);
                    DisplayUsers();
                }
            }
        }
        private void DeleteUser()
        {
            if (listOfUsers.GetList() != null && listOfUsers.GetList().Count() > 0)
            {
                UserViewModel viewModel = (UserViewModel)ctrGridUser.SelectedCells[0].OwningRow.DataBoundItem;
                User user = new User();
                foreach (User us in listOfUsers.GetList())
                {
                    if (us.Id == viewModel.Id)
                    {
                        user = us;
                    }
                }
                var form = new ConfirmForm(user);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    listOfUsers.Remove(user);
                    DisplayUsers();
                }
            }
        }
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
        }
        private void BtnAddUserContextMenu_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        private void BtnEditUserContextMenu_Click(object sender, EventArgs e)
        {
            EditUser();
        }
        private void BtnAddAwardContextMenu_Click(object sender, EventArgs e)
        {
            AddAward();
        }
        private void BtnEditAwardContextMenu_Click(object sender, EventArgs e)
        {
            EditAward();
        }
        private void AddAward()
        {
            var form = new AwardForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listOfAwards.Add(new Award(_awardId, form.AwardName, form.AwardDesc));
                DisplayAwards();
            }
        }
        private void EditAward()
        {
            if (ctrGridAward.SelectedCells.Count > 0)
            {
                int id = (int)ctrGridAward.Rows[ctrGridAward.SelectedCells[0].RowIndex].Cells[2].Value;
                Award award = new Award();
                foreach (Award aw in listOfAwards.GetList())
                {
                    if (aw.AwardId == id)
                    {
                        award = aw;
                    }
                }

                var form = new AwardForm(award);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    award.AwardName = form.AwardName;
                    award.AwardDescription = form.AwardDesc;
                    listOfAwards.Edit(award);
                    DisplayAwards();
                }
            }
        }

        private void DeleteAward()
        {
            if (listOfAwards != null && listOfAwards.GetList().Count() > 0)
            {
                int id = (int)ctrGridAward.Rows[ctrGridAward.SelectedCells[0].RowIndex].Cells[2].Value;
                Award deletedAward = new Award();
                foreach (Award aw in listOfAwards.GetList())
                {
                    if (aw.AwardId == id)
                    {
                        deletedAward = aw;
                    }
                }
                var form = new ConfirmForm(deletedAward);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (User user in listOfUsers.GetList())
                    {
                        user.Awards.Remove(deletedAward);
                    }
                    listOfAwards.Remove(deletedAward);
                    DisplayAwards();
                    DisplayUsers();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctrGridUser.AutoGenerateColumns = false;
            ctrGridAward.AutoGenerateColumns = false;
            ctrGridUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ctrGridUser.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DisplayAwards();
            DisplayUsers();
        }

        private void BtnDeleteAwardContextMenu_Click(object sender, EventArgs e)
        {
            DeleteAward();
        }

        private void BtnDeleteUserContextMenu_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void BtnAddUser_Click_1(object sender, EventArgs e)
        {
            AddUser();
        }

        private void BtnEditUser_Click_1(object sender, EventArgs e)
        {
            EditUser();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void BtnAddAward_Click(object sender, EventArgs e)
        {
            AddAward();
        }

        private void BtnEditAward_Click(object sender, EventArgs e)
        {
            EditAward();
        }

        private void BtnDeleteAward_Click(object sender, EventArgs e)
        {
            DeleteAward();
        }

        private void DisplayUsers()
        {
            ctrGridUser.DataSource = null;
            BindingList<UserViewModel> viewModel = new BindingList<UserViewModel>();
            foreach (User user in listOfUsers.GetList())
            {
                viewModel.Add(new UserViewModel(user));
            }
            ctrGridUser.DataSource = viewModel.ToTable();
        }

        private void DisplayAwards()
        {
            ctrGridAward.DataSource = null;
            ctrGridAward.DataSource = listOfAwards.GetList().ToTable();
        }

    }

    public static class ListExtension
    {
        public static DataTable ToTable<T>(this IEnumerable<T> list)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            for (var i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
