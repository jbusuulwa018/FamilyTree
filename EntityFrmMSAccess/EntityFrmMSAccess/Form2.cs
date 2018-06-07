using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EntityFrmMSAccess
{
    public partial class frmEnterText : MetroForm
    {
        public frmEnterText()
        {
            InitializeComponent();

            Dictionary<string, string> gender = new Dictionary<string, string>();
            gender.Add("M", "Male");
            gender.Add("F", "Female");
            
            this.cmbGender.DataSource = new BindingSource(gender, null);
            this.cmbGender.DisplayMember = "Value";
            this.cmbGender.ValueMember = "Key";



        }

        public string Get_FormText()
        {
            return txtNodeName.Text;
        }
        public string Get_GenderText()
        {
            return cmbGender.SelectedValue.ToString();
        }



        private void frmEnterText_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
