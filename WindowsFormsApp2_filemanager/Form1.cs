using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_filemanager
{
    public partial class Form1 : Form
    {
        ICommand dlg;  //tham khảo đến form chức năng mà người dùng muốn dùng
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuFileDeepLen_Click(object sender, EventArgs e)
        {
            //tạo Form xóa file theo pattern và hiển thị nó để người dùng làm việc
            dlg = new CDeepLengthDlg();
            dlg.Show();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
