using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CARE_RACE_GAME
{
    public partial class PlayerInfo : Form
    {
        public PlayerInfo()
        {
            InitializeComponent();
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "A";
            FileStream fs = new FileStream("d:\\playerinfo.txt",
            FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            while (str != "")
            {
                
                sw.WriteLine(str);
                
            }
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\playerinfo.txt",
         FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string input = Console.ReadLine();
            string str = sr.ReadLine();
            while (str != null)
            {
                if (str.Contains(input))
                {
                    Console.WriteLine("This player's highscore is " + str);
                }
                
            }
            
            sr.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\playerinfo.txt",
        FileMode.Open, FileAccess.Read);
            
            
            
            fs.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
