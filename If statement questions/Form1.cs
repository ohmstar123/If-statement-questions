using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_statement_questions
{
    public partial class Form1 : Form
    {
        

        

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);

           string stringOne = colorInput.Text;
           string stringTwo = shapeInput.Text;
            

            if (stringOne == "r")
            {
                drawPen = new Pen(Color.Red, 10);
            }
            
            if (stringOne == "g")
            {
                drawPen = new Pen(Color.Green, 10);
            }

            if (stringTwo == "rectangle")
            {
                g.DrawRectangle(drawPen, 30, 30, 100, 200);
            }
            else
            {
                g.DrawEllipse(drawPen, 25, 25, 100, 100);
            }



        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.AliceBlue);

            shapeInput.Text = "";
            colorInput.Text = "";


        }
    }
}
