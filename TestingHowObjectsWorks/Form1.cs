using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingHowObjectsWorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // After clicking button, our 3 new objects will display their variables
        private void button1_Click(object sender, EventArgs e)
        {

                Clown oneClown = new Clown();
                oneClown.Name = "Bartek";
                oneClown.Height = 150 ;
                oneClown.TalkAboutYourSelf(); //We use our new object clown with method created in Clown.cs in this way we can save time and make the code more readable

                Clown secondClown = new Clown();
                secondClown.Name = "Jasiek";
                secondClown.Height = 178;
                secondClown.TalkAboutYourSelf();

                Clown thirdClown = new Clown();
                thirdClown.Name = "Dawid";
                thirdClown.Height = 193 - oneClown.Height; // We can use data they store and use them like normal variables. For example clown one is storing .Height = 150. So 193 - 150 should equal 43
                thirdClown.TalkAboutYourSelf();
            
        }
    }
}
