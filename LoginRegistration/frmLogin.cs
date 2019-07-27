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
    public partial class frmLogin : Form
    {
        MicronDbContext micron = new MicronDbContext();

        public frmLogin()
        {
            InitializeComponent();
            //make form draggable
            
            bunifuFormDock1.SubscribeControlToDragEvents(pnlHeader, true);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //validate
            if (txtUser.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Invalid UserName.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                return;
            }
            if (txtPassw.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Invalid Password.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                return;
            }

            //check database

            var users = micron.GetRecords<Data.Models.User>($"(UserName = '{txtUser.Text.Trim()}' AND Password = '{txtPassw.Text.Trim()}')");

            if (users.Count()==0)
            {
                Bunifu.Snackbar.Show(this, "Invalid Login Credentials.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

           
            this.Hide();
            new frmMain(users.FirstOrDefault()).ShowDialog();
            this.Show();

        }
    }
}
