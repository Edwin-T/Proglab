using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgamakouaLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {     /* edwin, 10/5/2022, Not that complex! */
            InitializeComponent();
        }
        

        /* this event does noting*/
        
            
                
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            /* the event hides the picture and data label */
            picEM.Hide();
            lblSoccer.Hide();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            /* Displays text in data label and hides picture */
            picEM.Hide();
            lblSoccer.Show();

            //the label text was used to display information
            lblSoccer.Text= "My topic is"+ " " + lblTitle.Text + "\n\n It is a game involving two teams of 11 players who try to maneuver the ball into the other team's goal without using their hands or arms. The team that scores more goals wins.\r\n\r\nThe best football Player is Lionel Messi,Currently playing at PSG he showed up in FC Barcelona.";
        }

        private void picEM_Click(object sender, EventArgs e)
        {
            /* the event displays a message box with the entered data */
            MessageBox.Show("The only player that has Seven Golden Balls", "Edwin Arcange");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {  /* declare  3 local variable */
            int operand1, operand2, answer;

            // Read from textbox  and convert to int
            operand1 = Convert.ToInt32(txtNumber.Text);
            operand2 = Convert.ToInt32(txtMultiply.Text);

            // do the math
            answer = operand1 * operand2;
             
            // Convert the answer to string and display
            lblAnswer.Text =Convert.ToString(answer);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // sets textboxes and answer label to be blank and puts the cursor on the top textbox 
            txtNumber.Text="";
            txtMultiply.Text="";
            lblAnswer.Text="";
            txtNumber.Focus();
        }
    }
}
