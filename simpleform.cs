using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

class simpleform
{
   public static void Main(string[] args)
       {
            Form f1 = new Form();
            f1.Text = "myform";
            f1.Size = new Size(260,265);
            f1.Location = new Point(20,20);
            f1.BackColor = Color.Blue;
            f1.ShowDialog();
        }
 }   
