using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace ActiveDirectoryGroupsUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private List<String> GetActive_Directory_Groups(String userName)
        {
            List<String> result = new List<String>();

            WindowsIdentity wi = new WindowsIdentity(userName);

            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    string item = group.Translate(typeof(NTAccount)).ToString();

                    item = item.Replace(@"HCA\", "");
                    item = item.Substring(3, 6);

                    result.Add(item);
                }
                catch
                {
                }
                
            }
           
            return result;
        }

        private void btnGetGroups_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Username");
                return;
            }

            List<String> groups = GetActive_Directory_Groups(txtUserName.Text);

            if(groups.Count() == 0)
            {
                MessageBox.Show("No Groups Found!!");
                return;
            }

            foreach (String group in groups)
            {
                txtGroups.AppendText(group + "\t\r");
            }
        }
    }
}


