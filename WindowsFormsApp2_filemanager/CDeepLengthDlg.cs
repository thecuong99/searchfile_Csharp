using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;


namespace WindowsFormsApp2_filemanager
{
    class CDeepLengthDlg : CRecursiveBrowseDlg
    {
        //định nghĩa các thuộc tính dữ liệu cần dùng
        int DeepLength;
        String path;

        //override hàm InitForm
        public override void InitForm()
        {
            //hiệu chỉnh các chuỗi caption cho các phần tử giao diện
            this.Text = "Chức năng tính độ sâu sâu nhất của 1 nhánh thư mục";
            this.lblStartDir.Text = "Thư mục bắt đầu tính :";
            this.lblPattern.Text = "Nhập pattern :";
            this.lblOutput.Text = "Kết quả tính :";
            this.btnBrowse.Text = "Browse";
            this.btnStart.Text = "Start";
        }

        //override hàm Prolog
        public override void Prolog()
        {
            DeepLength = 0;
        }

        //override hàm Action để thực hiện tính độ sâu max của căy thư mực
        public override void Action(String fname, byte fop)
        {
            //tách đường dẫn của phần tử thành các thành phần rời rạc
            string[] parts = fname.Split('\\');
            if (parts.Length > DeepLength)
            {  //nếu độ sâu của thành phần hiện hành lớn nhất 
                DeepLength = parts.Length;
                path = fname;
            }
        }

        //override hàm Epilog
        public override void Epilog()
        {
            //lbOutput.Items.Clear();
            //lbOutput.Items.Add("Do sau max la : " + DeepLength);
            //lbOutput.Items.Add("Phan tu co do sau max la : ");
            //lbOutput.Items.Add(path);
            this.richTextBox_lbOutput.AppendText("\n" + "Do sau max la : " + DeepLength);
            this.richTextBox_lbOutput.AppendText("\n" + "Phan tu co độ sâu max la : " + path);
        }
    } //hết class
}
