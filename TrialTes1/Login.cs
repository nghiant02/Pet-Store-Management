using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATrialTes1
{
    public partial class Login : Form
    {
        PetShopMemberService _petShopMemberService;
        public Login()
        {
            _petShopMemberService = new PetShopMemberService();
            InitializeComponent();
            txtEmail.Text = "staff@PetStore.com.au";
            txtPassword.Text = "@2";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PetShopMember petShopMember = _petShopMemberService.GetAll().Where(p=>p.EmailAddress == txtEmail.Text && p.MemberPassword == txtPassword.Text && p.MemberRole == 2).FirstOrDefault();
            if (petShopMember != null)
            {
                Managerment managerment = new Managerment(petShopMember);
                this.Hide();
                managerment.Show();
            }else
            {
                MessageBox.Show("You have no permistion to access this funtion!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
