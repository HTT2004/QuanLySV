namespace Quanly_Sinhvien
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.quanlisinhvien = new System.Windows.Forms.Label();
            this.boxInput = new System.Windows.Forms.GroupBox();
            this.boxGioiTinhInput = new System.Windows.Forms.TextBox();
            this.labelGT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxKhoaInput = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonNhap = new System.Windows.Forms.Button();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.boxPointStudyInput = new System.Windows.Forms.TextBox();
            this.labelPoint = new System.Windows.Forms.Label();
            this.boxPointTryHardInput = new System.Windows.Forms.TextBox();
            this.labelTryHard = new System.Windows.Forms.Label();
            this.boxMSSVInput = new System.Windows.Forms.TextBox();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.boxDateInput = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.boxNameInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.boxFunction = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoaHetSV = new System.Windows.Forms.Button();
            this.buttonXoaSV = new System.Windows.Forms.Button();
            this.boxDatasinhvien = new System.Windows.Forms.GroupBox();
            this.listItems = new System.Windows.Forms.ListView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.boxInput.SuspendLayout();
            this.boxFunction.SuspendLayout();
            this.boxDatasinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanlisinhvien
            // 
            this.quanlisinhvien.AutoSize = true;
            this.quanlisinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlisinhvien.ForeColor = System.Drawing.Color.Red;
            this.quanlisinhvien.Location = new System.Drawing.Point(496, 11);
            this.quanlisinhvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quanlisinhvien.Name = "quanlisinhvien";
            this.quanlisinhvien.Size = new System.Drawing.Size(420, 36);
            this.quanlisinhvien.TabIndex = 0;
            this.quanlisinhvien.Text = "Chương trình quản lý sinh viên";
            // 
            // boxInput
            // 
            this.boxInput.Controls.Add(this.boxGioiTinhInput);
            this.boxInput.Controls.Add(this.labelGT);
            this.boxInput.Controls.Add(this.button1);
            this.boxInput.Controls.Add(this.boxKhoaInput);
            this.boxInput.Controls.Add(this.buttonXoa);
            this.boxInput.Controls.Add(this.buttonNhap);
            this.boxInput.Controls.Add(this.labelKhoa);
            this.boxInput.Controls.Add(this.boxPointStudyInput);
            this.boxInput.Controls.Add(this.labelPoint);
            this.boxInput.Controls.Add(this.boxPointTryHardInput);
            this.boxInput.Controls.Add(this.labelTryHard);
            this.boxInput.Controls.Add(this.boxMSSVInput);
            this.boxInput.Controls.Add(this.labelMSSV);
            this.boxInput.Controls.Add(this.boxDateInput);
            this.boxInput.Controls.Add(this.labelDate);
            this.boxInput.Controls.Add(this.boxNameInput);
            this.boxInput.Controls.Add(this.labelName);
            this.boxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInput.Location = new System.Drawing.Point(16, 30);
            this.boxInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxInput.Name = "boxInput";
            this.boxInput.Padding = new System.Windows.Forms.Padding(4);
            this.boxInput.Size = new System.Drawing.Size(456, 384);
            this.boxInput.TabIndex = 1;
            this.boxInput.TabStop = false;
            this.boxInput.Text = "Nhập sinh viên";
            // 
            // boxGioiTinhInput
            // 
            this.boxGioiTinhInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxGioiTinhInput.Location = new System.Drawing.Point(156, 169);
            this.boxGioiTinhInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxGioiTinhInput.Name = "boxGioiTinhInput";
            this.boxGioiTinhInput.Size = new System.Drawing.Size(225, 26);
            this.boxGioiTinhInput.TabIndex = 4;
            // 
            // labelGT
            // 
            this.labelGT.AutoSize = true;
            this.labelGT.Location = new System.Drawing.Point(8, 176);
            this.labelGT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGT.Name = "labelGT";
            this.labelGT.Size = new System.Drawing.Size(71, 20);
            this.labelGT.TabIndex = 17;
            this.labelGT.Text = "Giới tính";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(188, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxKhoaInput
            // 
            this.boxKhoaInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxKhoaInput.Location = new System.Drawing.Point(156, 306);
            this.boxKhoaInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxKhoaInput.Name = "boxKhoaInput";
            this.boxKhoaInput.Size = new System.Drawing.Size(225, 26);
            this.boxKhoaInput.TabIndex = 7;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoa.Location = new System.Drawing.Point(296, 348);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 28);
            this.buttonXoa.TabIndex = 15;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonNhap
            // 
            this.buttonNhap.BackColor = System.Drawing.Color.LightCyan;
            this.buttonNhap.Location = new System.Drawing.Point(40, 348);
            this.buttonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(140, 28);
            this.buttonNhap.TabIndex = 8;
            this.buttonNhap.Text = "Nhập dữ liệu";
            this.buttonNhap.UseVisualStyleBackColor = false;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(8, 314);
            this.labelKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(47, 20);
            this.labelKhoa.TabIndex = 12;
            this.labelKhoa.Text = "Khoa";
            // 
            // boxPointStudyInput
            // 
            this.boxPointStudyInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxPointStudyInput.Location = new System.Drawing.Point(156, 257);
            this.boxPointStudyInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxPointStudyInput.Name = "boxPointStudyInput";
            this.boxPointStudyInput.Size = new System.Drawing.Size(225, 26);
            this.boxPointStudyInput.TabIndex = 6;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(8, 261);
            this.labelPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(127, 20);
            this.labelPoint.TabIndex = 8;
            this.labelPoint.Text = "Điểm trung bình";
            // 
            // boxPointTryHardInput
            // 
            this.boxPointTryHardInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxPointTryHardInput.Location = new System.Drawing.Point(156, 209);
            this.boxPointTryHardInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxPointTryHardInput.Name = "boxPointTryHardInput";
            this.boxPointTryHardInput.Size = new System.Drawing.Size(225, 26);
            this.boxPointTryHardInput.TabIndex = 5;
            // 
            // labelTryHard
            // 
            this.labelTryHard.AutoSize = true;
            this.labelTryHard.Location = new System.Drawing.Point(8, 217);
            this.labelTryHard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTryHard.Name = "labelTryHard";
            this.labelTryHard.Size = new System.Drawing.Size(121, 20);
            this.labelTryHard.TabIndex = 6;
            this.labelTryHard.Text = "Điểm rèn luyện";
            // 
            // boxMSSVInput
            // 
            this.boxMSSVInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxMSSVInput.Location = new System.Drawing.Point(156, 126);
            this.boxMSSVInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxMSSVInput.Name = "boxMSSVInput";
            this.boxMSSVInput.Size = new System.Drawing.Size(225, 26);
            this.boxMSSVInput.TabIndex = 3;
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Location = new System.Drawing.Point(8, 129);
            this.labelMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(56, 20);
            this.labelMSSV.TabIndex = 4;
            this.labelMSSV.Text = "MSSV";
            // 
            // boxDateInput
            // 
            this.boxDateInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxDateInput.Location = new System.Drawing.Point(156, 86);
            this.boxDateInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxDateInput.Name = "boxDateInput";
            this.boxDateInput.Size = new System.Drawing.Size(225, 26);
            this.boxDateInput.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(8, 90);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(88, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Ngày sinh ";
            this.labelDate.Click += new System.EventHandler(this.boxDateInput_Click);
            // 
            // boxNameInput
            // 
            this.boxNameInput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.boxNameInput.Location = new System.Drawing.Point(99, 41);
            this.boxNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.boxNameInput.Name = "boxNameInput";
            this.boxNameInput.Size = new System.Drawing.Size(283, 26);
            this.boxNameInput.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên";
            // 
            // boxFunction
            // 
            this.boxFunction.Controls.Add(this.button4);
            this.boxFunction.Controls.Add(this.button3);
            this.boxFunction.Controls.Add(this.button2);
            this.boxFunction.Controls.Add(this.buttonThoat);
            this.boxFunction.Controls.Add(this.buttonXoaHetSV);
            this.boxFunction.Controls.Add(this.buttonXoaSV);
            this.boxFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFunction.Location = new System.Drawing.Point(16, 421);
            this.boxFunction.Margin = new System.Windows.Forms.Padding(4);
            this.boxFunction.Name = "boxFunction";
            this.boxFunction.Padding = new System.Windows.Forms.Padding(4);
            this.boxFunction.Size = new System.Drawing.Size(456, 236);
            this.boxFunction.TabIndex = 2;
            this.boxFunction.TabStop = false;
            this.boxFunction.Text = "Chức năng";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Location = new System.Drawing.Point(296, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xuất danh sách sinh viên";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Location = new System.Drawing.Point(156, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xếp hạng sinh viên";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(12, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xếp loại sinh viên";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.LightCyan;
            this.buttonThoat.Location = new System.Drawing.Point(296, 148);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(135, 49);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoaHetSV
            // 
            this.buttonXoaHetSV.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoaHetSV.Location = new System.Drawing.Point(156, 37);
            this.buttonXoaHetSV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaHetSV.Name = "buttonXoaHetSV";
            this.buttonXoaHetSV.Size = new System.Drawing.Size(132, 49);
            this.buttonXoaHetSV.TabIndex = 1;
            this.buttonXoaHetSV.Text = "Xóa tất cả dữ liệu";
            this.buttonXoaHetSV.UseVisualStyleBackColor = false;
            this.buttonXoaHetSV.Click += new System.EventHandler(this.buttonXoaHetSV_Click);
            // 
            // buttonXoaSV
            // 
            this.buttonXoaSV.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoaSV.Location = new System.Drawing.Point(12, 37);
            this.buttonXoaSV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaSV.Name = "buttonXoaSV";
            this.buttonXoaSV.Size = new System.Drawing.Size(123, 49);
            this.buttonXoaSV.TabIndex = 0;
            this.buttonXoaSV.Text = "Xóa dữ liệu sinh viên";
            this.buttonXoaSV.UseVisualStyleBackColor = false;
            this.buttonXoaSV.Click += new System.EventHandler(this.buttonXoaSV_Click);
            // 
            // boxDatasinhvien
            // 
            this.boxDatasinhvien.Controls.Add(this.listItems);
            this.boxDatasinhvien.Location = new System.Drawing.Point(480, 86);
            this.boxDatasinhvien.Margin = new System.Windows.Forms.Padding(4);
            this.boxDatasinhvien.Name = "boxDatasinhvien";
            this.boxDatasinhvien.Padding = new System.Windows.Forms.Padding(4);
            this.boxDatasinhvien.Size = new System.Drawing.Size(1088, 571);
            this.boxDatasinhvien.TabIndex = 3;
            this.boxDatasinhvien.TabStop = false;
            this.boxDatasinhvien.Text = "Dữ liệu sinh viên";
            // 
            // listItems
            // 
            this.listItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listItems.FullRowSelect = true;
            this.listItems.GridLines = true;
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(1, 25);
            this.listItems.Margin = new System.Windows.Forms.Padding(4);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(1085, 538);
            this.listItems.TabIndex = 0;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.Details;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1603, 672);
            this.Controls.Add(this.boxDatasinhvien);
            this.Controls.Add(this.boxFunction);
            this.Controls.Add(this.boxInput);
            this.Controls.Add(this.quanlisinhvien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ManageStudent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.boxInput.ResumeLayout(false);
            this.boxInput.PerformLayout();
            this.boxFunction.ResumeLayout(false);
            this.boxDatasinhvien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quanlisinhvien;
        private System.Windows.Forms.GroupBox boxInput;
        private System.Windows.Forms.GroupBox boxFunction;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox boxNameInput;
        private System.Windows.Forms.TextBox boxDateInput;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.TextBox boxPointStudyInput;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox boxPointTryHardInput;
        private System.Windows.Forms.Label labelTryHard;
        private System.Windows.Forms.TextBox boxMSSVInput;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonNhap;
        private System.Windows.Forms.GroupBox boxDatasinhvien;
        private System.Windows.Forms.TextBox boxKhoaInput;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoaHetSV;
        private System.Windows.Forms.Button buttonXoaSV;
        private System.Windows.Forms.TextBox boxGioiTinhInput;
        private System.Windows.Forms.Label labelGT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

