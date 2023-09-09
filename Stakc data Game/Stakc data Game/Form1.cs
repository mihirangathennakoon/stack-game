using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stakc_data_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int blue = 0;
        int yellow = 0;
        int orange = 0;
        int red = 0;
        int green = 0;
        int purp = 0;
        int peek = -1;
        string name;

        Boolean isFull()
        {
            if(peek.Equals(5))
            {
                return true;
            }
            return false;
        }

        Boolean isEmpty()
        {
            if (peek.Equals(-1))
            {
                return true;
            }
            return false;
        }

        string[] arr = new string[6];

        void push(string data)
        {
            arr[++peek] = data;
            Console.WriteLine(arr[peek]);

        }

        void pop()
        {
            if (peek.Equals(0))
            {
                Console.WriteLine(arr[peek]);
                name = arr[peek];
            }
            else
            {             
                name = arr[peek--];
            }

            if (name== "picBoxBlue")
            {
                picBoxBlue.Visible = true;
            }
            if (name == "picBoxYellow")
            {
                picBoxYellow.Visible = true;
            }
            if (name == "picBoxPurpul")
            {
                picBoxPurpul.Visible = true;
            }
            if (name == "picBoxRed")
            {
                picBoxRed.Visible = true;
            }
            if (name == "picBoxOrange")
            {
                picBoxOrange.Visible = true;
            }
            if (name == "picBoxGreen")
            {
                picBoxGreen.Visible = true;
            }
           
        }
       
        private void picBoxBlue_Click(object sender, EventArgs e)
        {
            blue = 1;
            picBoxBlue.Visible = false;
            push(picBoxBlue.Name);
        }

        private void picBoxYellow_Click(object sender, EventArgs e)
        {
            yellow = 1;
            picBoxYellow.Visible = false;
            push(picBoxYellow.Name);
        }

        private void picBoxPurpul_Click(object sender, EventArgs e)
        {
            purp= 1;
            picBoxPurpul.Visible = false;
            push(picBoxPurpul.Name);
        }

        private void picBoxRed_Click(object sender, EventArgs e)
        {
            red= 1;
            picBoxRed.Visible = false;
            push(picBoxRed.Name);
        }

        private void picBoxOrange_Click(object sender, EventArgs e)
        {
            orange = 1;
            picBoxOrange.Visible = false;
            push(picBoxOrange.Name);
        }

        private void picBoxGreen_Click(object sender, EventArgs e)
        {
            green = 1;
            picBoxGreen.Visible = false;
            push(picBoxGreen.Name);
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            if (isEmpty()==false)
            {
                pop();
            }
            else
            {
                Console.WriteLine("You have no colors to POP");
            }
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
