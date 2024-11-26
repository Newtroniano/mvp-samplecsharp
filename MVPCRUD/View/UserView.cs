using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPCRUD.View
{
    public partial class UserVIew : Form, IUserView
    {
        public string UserID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nick { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CPF { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataCadastro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SerachValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isSucessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UserVIew()
        {
            InitializeComponent();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nickName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userEmailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassbox_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetPetListBindinSource(BindingSource userlist)
        {
            throw new NotImplementedException();
        }
    }
}
