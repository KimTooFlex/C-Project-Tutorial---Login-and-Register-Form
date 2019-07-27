using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
namespace LoginRegistration
{
    public partial class frmMain : Form
    {
        MicronDbContext micron = new MicronDbContext();
        private readonly Data.Models.User _user;

        public frmMain(Data.Models.User user)
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(pnlHeader,true);
            micron.BindDatagridViewEvents(grid, typeof(Data.Models.User));
            this._user = user;

            grid.ReadOnly = !_user.IsAdmin; //only admins can edit
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            indcator.Left = bunifuFlatButton1.Left;
            indcator.Width = bunifuFlatButton1.Width;
            bunifuPages1.SetPage(0);
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

            if (!_user.IsAdmin)
            {
                Bunifu.Snackbar.Show(this, "Only Admins can Add Users", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            indcator.Left = bunifuFlatButton2.Left;
            indcator.Width = bunifuFlatButton2.Width;
            bunifuPages1.SetPage(1);
        }

        void LoadData()
        {
            grid.DataSource = micron.Query("SELECT * FROM `users`"); 
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
        void ResetInput()
        {
            txtFullName.Text = "";
            txtUserName.Text = "";
            txtPassw.Text = "";
            txtPassw2.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            chMale.Checked = true;
            chAdmin.Value = false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //validate

            if (txtFullName.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Invalid UserName.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (txtUserName.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Invalid FullName.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }
            if (txtPassw.Text.Trim().Length ==0 )
            {
                Bunifu.Snackbar.Show(this, "Password required.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (txtPassw.Text.Trim().Length <5 )
            {
                Bunifu.Snackbar.Show(this, "Password Too Weak.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                return;
            }

            if (txtPassw.Text.Trim() != txtPassw2.Text.Trim())
            {
                Bunifu.Snackbar.Show(this, "Passwords do not match.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (txtPhone.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Phone required.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Email required.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            //create new user and update database

            var user = new Data.Models.User()
            {
                FullName = txtFullName.Text.Trim(),
                UserName = txtUserName.Text.Trim(),
                Password = txtPassw.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone =  txtPhone.Text.Trim(),
                Gender = chMale.Checked ? "Male":"Female",
                IsAdmin = chAdmin.Value, 
            };

            micron.Save(user);
            Bunifu.Snackbar.Show(this, "User Successfully Added.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

            //switch to page 1 and reload data
            ResetInput();
            LoadData();
            bunifuPages1.SetPage(0);

        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            LoadData();
            Bunifu.Snackbar.Show(this, "Successful.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(!(grid.CurrentRow.Index>=0))
            {
                e.Cancel = true;
                return;
            }
            //only admins can delete
            e.Cancel = !_user.IsAdmin;
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete selected users

            foreach (DataGridViewRow item in grid.SelectedRows) //bug :(
            {
                var id = item.Cells[0].Value;
                var user = micron.GetRecord<Data.Models.User>(id);
                micron.Delete(user);
            }

            LoadData();

            Bunifu.Snackbar.Show(this, "Successfully Deleted.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

        }
    }
}
