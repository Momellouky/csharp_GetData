namespace EnterData
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.Header = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.User_PictureBox = new System.Windows.Forms.PictureBox();
            this.Add_Image_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.User_PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Mokhtar Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(-1, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(885, 60);
            this.Header.TabIndex = 0;
            this.Header.Text = "Wecome To USP Prod.";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtId
            // 
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(194, 142);
            this.TxtId.MaxLength = 50;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(373, 26);
            this.TxtId.TabIndex = 1;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(194, 207);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(373, 26);
            this.TxtName.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(194, 270);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(373, 26);
            this.TxtPassword.TabIndex = 3;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(94, 142);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(99, 26);
            this.LblId.TabIndex = 4;
            this.LblId.Text = "ID       : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(74, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 26);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name    : ";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(54, 270);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(137, 26);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Password : ";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(59, 348);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(103, 38);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFind.FlatAppearance.BorderSize = 0;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFind.ForeColor = System.Drawing.Color.White;
            this.BtnFind.Location = new System.Drawing.Point(194, 348);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(103, 38);
            this.BtnFind.TabIndex = 8;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.FlatAppearance.BorderSize = 0;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.ForeColor = System.Drawing.Color.White;
            this.BtnShow.Location = new System.Drawing.Point(331, 348);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(103, 38);
            this.BtnShow.TabIndex = 9;
            this.BtnShow.Text = "Show ";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(78)))), ((int)(((byte)(20)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(464, 348);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(103, 38);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // User_PictureBox
            // 
            this.User_PictureBox.Image = global::EnterData.Properties.Resources.None_Img;
            this.User_PictureBox.Location = new System.Drawing.Point(609, 115);
            this.User_PictureBox.Name = "User_PictureBox";
            this.User_PictureBox.Size = new System.Drawing.Size(221, 216);
            this.User_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_PictureBox.TabIndex = 11;
            this.User_PictureBox.TabStop = false;
            this.User_PictureBox.Click += new System.EventHandler(this.User_PictureBox_Click);
            this.User_PictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.User_PictureBox_DragDrop);
            this.User_PictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.User_PictureBox_DragEnter);
            // 
            // Add_Image_Btn
            // 
            this.Add_Image_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.Add_Image_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Image_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Image_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Image_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Image_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Image_Btn.Location = new System.Drawing.Point(609, 348);
            this.Add_Image_Btn.Name = "Add_Image_Btn";
            this.Add_Image_Btn.Size = new System.Drawing.Size(221, 38);
            this.Add_Image_Btn.TabIndex = 12;
            this.Add_Image_Btn.Text = "Add";
            this.Add_Image_Btn.UseVisualStyleBackColor = false;
            this.Add_Image_Btn.Click += new System.EventHandler(this.Add_Image_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.Add_Image_Btn);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.User_PictureBox);
            this.panel1.Controls.Add(this.LblId);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.LblPassword);
            this.panel1.Controls.Add(this.BtnFind);
            this.panel1.Controls.Add(this.BtnRegister);
            this.panel1.Location = new System.Drawing.Point(-1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 502);
            this.panel1.TabIndex = 15;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(135)))), ((int)(((byte)(31)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(464, 392);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(103, 38);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox User_PictureBox;
        private System.Windows.Forms.Button Add_Image_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ErrorProvider ErrorProv;
    }
}

