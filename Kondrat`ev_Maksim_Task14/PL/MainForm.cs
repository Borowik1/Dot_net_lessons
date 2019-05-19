using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class MainForm : Form
    {
        enum SortOrder { Asc, Desc };
        SortOrder sortOrder = SortOrder.Asc;

        private readonly UsersBL listOfUsers;
        private readonly AwardsBL listOfAwards;
        private int _userId = 1;
        private int _awardId = 1;
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
                listOfUsers.Add(new User(_userId++, form.FirstName, form.LastName, form.DateOfBirth, form.ListOfAwards));
                ctrGridUser.DataSource = null;
                ctrGridUser.DataSource = listOfUsers;
            }
        }
        private void EditUser()
        {
            if (ctrGridUser.SelectedCells.Count > 0)
            {
                User user = (User)ctrGridUser.SelectedCells[0].OwningRow.DataBoundItem;
                UserForm form = new UserForm(user, listOfAwards.GetList());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.DateOfBirth = form.DateOfBirth;
                    user.Awards = form.ListOfAwards;
                    ctrGridUser.DataSource = null;
                    ctrGridUser.DataSource = listOfUsers.GetList();
                }
            }
        }
        private void DeleteUser()
        {
            if (listOfUsers.GetList() != null & listOfUsers.GetList().Count() > 0)
            {
                var form = new ConfirmForm((User)ctrGridUser.SelectedCells[0].OwningRow.DataBoundItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    listOfUsers.Remove((User)ctrGridUser.SelectedCells[0].OwningRow.DataBoundItem);
                    ctrGridUser.DataSource = null;
                    ctrGridUser.DataSource = listOfUsers;
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
                listOfAwards.Add(new Award(_awardId++, form.AwardName, form.AwardDesc));
                ctrGridAward.DataSource = null;
                ctrGridAward.DataSource = listOfAwards;
            }
        }
        private void EditAward()
        {
            Award award = (Award)ctrGridAward.SelectedCells[0].OwningRow.DataBoundItem;
            var form = new AwardForm(award);
            if (form.ShowDialog() == DialogResult.OK)
            {
                award.AwardName = form.AwardName;
                award.AwardDescription = form.AwardDesc;
                DisplayAwards();
            }
        }
        private void DeleteAward()
        {
            if (listOfAwards != null & listOfAwards.GetList().Count() > 0)
            {
                var form = new ConfirmForm((Award)ctrGridAward.SelectedCells[0].OwningRow.DataBoundItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var deletedAward = (Award)ctrGridAward.SelectedCells[0].OwningRow.DataBoundItem;
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
        private void CtrGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var headerName = ctrGridUser.Columns[e.ColumnIndex].DataPropertyName;

            if (headerName == "LastName")
            {
                if (sortOrder == SortOrder.Asc)
                {
                    sortOrder = SortOrder.Desc;
                    listOfUsers.SortUsersByLastNameAsc();
                }
                else
                {
                    sortOrder = SortOrder.Asc;
                    listOfUsers.SortUsersByLastNameDesc();
                }
            }

            if (headerName == "FirstName")
            {
                if (sortOrder == SortOrder.Asc)
                {
                    sortOrder = SortOrder.Desc;
                    listOfUsers.SortUsersByFirstNameAsc();
                }
                else
                {
                    sortOrder = SortOrder.Asc;
                    listOfUsers.SortUsersByFirstNameDesc();
                }
            }

            if (headerName == "DateOfBirth")
            {
                if (sortOrder == SortOrder.Asc)
                {
                    sortOrder = SortOrder.Desc;
                    listOfUsers.SortUsersByAgeAsc();
                }
                else
                {
                    sortOrder = SortOrder.Asc;
                    listOfUsers.SortUsersByAgeDesc();
                }
            }
            DisplayUsers();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void CtrGridAward_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var headerName = ctrGridAward.Columns[e.ColumnIndex].DataPropertyName;

            if (headerName == "AwardName")
            {
                if(sortOrder == SortOrder.Asc)
                {
                    sortOrder = SortOrder.Desc;
                    listOfAwards.SortAwardsByNameAsc();
                }
                else
                {
                    sortOrder = SortOrder.Asc;
                    listOfAwards.SortAwardsByNameDesc();
                }
            }

            DisplayAwards();
        }
        private void DisplayUsers()
        {
            ctrGridUser.DataSource = null;
            ctrGridUser.DataSource = listOfUsers.GetList();
        }

        private void DisplayAwards()
        {
            ctrGridAward.DataSource = null;
            ctrGridAward.DataSource = listOfAwards.GetList();
        }
    }
}
