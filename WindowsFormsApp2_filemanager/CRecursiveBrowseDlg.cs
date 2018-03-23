using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2_filemanager
{
    public partial class CRecursiveBrowseDlg : Form, ICommand
    {
        public CRecursiveBrowseDlg()
        {
            InitializeComponent();
            InitForm();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //tạo form duyệt chọn thư mục
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            //hiển thị form duyệt chọn thư mục để người dùng duyệt chọn thư mục làm việc
            dlg.ShowDialog();
            //hiển thị đừơng dẫn thư mục vào textbox txtStartDir
            txtStartDir.Text = dlg.SelectedPath;
        }

        private void btnBrowse_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //1. thiết lập các giá trị đầu để thực hiện chức năng
            Prolog();
            //2. duyệt cây và thực hiện chức năng trên từng phần tử tìm được
            DuyetCay(txtStartDir.Text, txtPattern.Text);
            //3. thực hiện các công việc kết thúc chức năng
            Epilog();

        }
        //thiết lập các chuỗi caption cho các đối tượng giao diện 
        virtual public void InitForm()
        {

        }
        //thiết lập các giá trị đầu để thực hiện chức năng
        virtual public void Prolog()
        {

        }
        //thực hiện chức năng trên phần tử  tìm được
        virtual public void Action(String fname, byte fop) {
            this.richTextBox_lbOutput.AppendText("\n" + fname);
        }
        //thực hiện các công việc kết thúc chức năng
        virtual public void Epilog() { }

        //duyệt cây và thực hiện chức năng trên từng phần tử tìm được    
        public void DuyetCay(String sdir, String spattern)
        {
            // tìm các file thỏa mãn pattern và xử lý
            string[] flist = Directory.GetFiles(sdir, spattern);
            //this.richTextBox_lbOutput.Clear();
            foreach (string fname in flist)
            {
                Action(fname, 0);
            }
            //xác định tất cả thư mục con
            string[] sdlistw = Directory.GetDirectories(sdir);
            //xác định tất cả thư mục con thỏa pattern
            string[] sdlist = Directory.GetDirectories(sdir, spattern);
            //duyệt xử lý từng thư mục con
            foreach (string subdir in sdlistw)
                if (thuocve(subdir, sdlist))
                {  //thư mục thỏa pattern
                    DuyetCay(subdir, "*");
                    Action(subdir, 1);
                }
                else //thư mục không thỏa pattern
                    DuyetCay(subdir, spattern);
        }
        //kiểm tra chuỗi s có nằm trong danh sách các chuỗi sl    
        private bool thuocve(String s, String[] sl)
        {
            int max = sl.Length - 1;
            for (int i = 0; i <= max; i++)
                if (s == sl[i]) return true;
            return false;   //trả về false nếu s không nằm trong danh sách 
        }

        private void CRecursiveBrowseDlg_Load(object sender, EventArgs e)
        {

        }
    }
}
