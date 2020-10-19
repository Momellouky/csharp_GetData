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

namespace EnterData
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent(); 
            

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader file_ = new StreamReader("Data.txt");
                string ReadFileData = file_.ReadLine();
                file_.Close(); 

                StreamWriter file = new StreamWriter("Data.txt", true);
                string data = TxtId.Text + ";" + TxtName.Text + ";" + TxtPassword.Text;
                //file.Close();
                if (TxtId.Text.Length == 0 || TxtName.Text.Length == 0 || TxtPassword.Text.Length == 0)
                {

                    string ErrorMessage = "Please enter all your Data"; 
                    MessageBox.Show(ErrorMessage);
                    TxtId.Focus();
                    return; 
                    
                }
                if ( TxtPassword.TextLength < 4)
                {

                    MessageBoxIcon icon = MessageBoxIcon.Warning; 
                    MessageBox.Show("Your password is weak.", "Password weak" , 0, icon);
                    TxtPassword.Focus();
                    TxtPassword.SelectAll();
                    return; 

                }

                if (ReadFileData.Contains(TxtId.Text + ";"))
                {
                    MessageBox.Show("This user already exist!");
                    return; 
                }

                file.WriteLine(data);
                TxtId.Clear();
                TxtName.Clear();
                TxtPassword.Clear();
                MessageBox.Show("Done");
                file.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            string msj = "Do you want to exit?";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(msj, "Allert", btn, icon); 
            if ( result == DialogResult.Yes)
            {
                Application.Exit();
            }
             
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            Form ShowData = new Form();
            TextBox txtShow = new TextBox(); 
            ShowData.StartPosition = FormStartPosition.CenterScreen;
            ShowData.Size = new System.Drawing.Size(300, 300);
            txtShow.Multiline = true;
            txtShow.Font = new Font(this.Font.ToString(), 9, FontStyle.Bold); 
            txtShow.ReadOnly = true; 
            txtShow.Dock = DockStyle.Fill; 

            try 
            {
                StreamReader file = new StreamReader("Data.txt");
                string GetData = file.ReadToEnd();
                file.Close();
                txtShow.Text = GetData;
                ShowData.Controls.Add(txtShow); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            ShowData.ShowDialog(); 


        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            bool found = false; 
            if (TxtId.Text.Trim() != "")
            {
                StreamReader file = new StreamReader("Data.txt");
                string GetData = "";
                do
                {

                    GetData = file.ReadLine();
                    if ( GetData != null)
                    { 
                        string[] Data = GetData.Split(';');
                        if (Data[0] == TxtId.Text)
                        {
                            TxtName.Text = Data[1];
                            TxtPassword.Text = Data[2];
                            found = true;
                       
                            break;
                        }
                    }
                    //else
                    //{
                    //    MessageBox.Show("User doesn't exist. ");
                    //    file.Close();
                    //    break;
                    //}


                } while (GetData != null);

            file.Close();

            }
            else
            {
                MessageBox.Show("Please enter an Id"); 
            }

            if (!found)
            {
                MessageBox.Show("user not found"); 
            }
        }
    }
}
