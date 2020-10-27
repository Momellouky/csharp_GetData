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
using System.Drawing.Imaging;

namespace EnterData
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            
            TxtPassword.PasswordChar = '*';
            

        }

        public void clear()
        {
            TxtId.Clear();
            TxtName.Clear();
            TxtPassword.Clear();
        }

        public void setErrorProvider(TextBox c )
        {
            if (string.IsNullOrEmpty(c.Text))
            {
                ErrorProv.SetError(c , "Enter This Field");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader file_ = new StreamReader("Data.txt");
                string ReadFileData = file_.ReadToEnd();
                file_.Close();

                /* check if the user already exists */ 

                if (!string.IsNullOrEmpty(TxtId.Text))
                {
                    if (ReadFileData.Contains(TxtId.Text + ";"))
                    {
                        MessageBox.Show("This user already exist!");
                        return;
                    }
                }

                StreamWriter file = new StreamWriter("Data.txt", true);
                string data = TxtId.Text + ";" + TxtName.Text + ";" + TxtPassword.Text;
                //file.Close();

                TextBox[] textBoxes = { TxtId, TxtName, TxtPassword }; 
                
                if (TxtId.Text.Length == 0 || TxtName.Text.Length == 0 || TxtPassword.Text.Length == 0)
                {

                    //string ErrorMessage = "Please enter all your Data"; 
                    //MessageBox.Show(ErrorMessage, "Missing information",0,MessageBoxIcon.Error);

                    setErrorProvider(TxtId);
                    setErrorProvider(TxtName);
                    setErrorProvider(TxtPassword); 

                    TxtId.Focus();
                    file.Close(); 
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

                file.WriteLine(data);

                /* save img in DataBase */

                if ( Directory.Exists(@"../../../Data_Image"))
                {
                    Directory.CreateDirectory(@"../../../Data_Image"); 
                }

                User_PictureBox.Image.Save(@"../../../Data_Image/" + TxtId.Text + ".jpg"); 
                

                /* end save Image in DataBase */ 
                
                foreach(Control c in Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Text = string.Empty; 
                }

                User_PictureBox.Image = Properties.Resources.None_Img;

                clear(); 

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

            /* convert from txtbox to label to get the readonly and deselected text feature */ 

            Label txtShow = new Label(); 

            ShowData.StartPosition = FormStartPosition.CenterScreen;
            ShowData.Size = new System.Drawing.Size(300, 300);

            txtShow.Font = new Font(this.Font.ToString(), 9, FontStyle.Bold); 
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
                            TxtPassword.PasswordChar = '\0';   
                            TxtPassword.Text = Data[2];
                            if (!File.Exists(@"../../../Data_Image/" + Data[0] + ".jpg"))
                            {  
                                User_PictureBox.Image = Properties.Resources.None_Img;
                            }
                            else
                            { 
                                User_PictureBox.Image = Image.FromFile(@"../../../Data_Image/" + Data[0] + ".jpg");
                            } 
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
                found = true; /* to do not run the next if statement, */ 
            }

            if (!found)
            {
                MessageBox.Show("user not found"); 
            }
        }

        private void Add_Image_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openfile.Title = "Choose an image";
            openfile.Filter = "Images|*.jpg;*.png";
            openfile.ShowDialog();

            /* get image path */

            string path = openfile.FileName;

            User_PictureBox.Image = Image.FromFile(path); 


        }



        private void ShowAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear(); 
            User_PictureBox.Image = Properties.Resources.None_Img;

            TxtPassword.PasswordChar = '*';

            ErrorProv.Clear(); 
        }

        private void User_PictureBox_Click(object sender, EventArgs e)
        {
            // 26/10/2020 NO CODE. 
        }
        
        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            User_PictureBox.AllowDrop = true; 
        }

        private void PastImg_Opening(object sender, CancelEventArgs e)
        {

        }
        string[] file = null;
        private void User_PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            file = (string[])e.Data.GetData(DataFormats.FileDrop);
            string pathExt = Path.GetExtension(file[0]);
            
            if (pathExt == ".jpg" && file.Count() == 1)
            {
                e.Effect = DragDropEffects.Copy; 
            }
            

        }

        private void User_PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            User_PictureBox.Image = Image.FromFile(file[0]); 
        }
    }
}
