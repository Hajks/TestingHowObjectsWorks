using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingHowObjectsWorks
{
    public class Clown
    {
        //We declare two public variables and creating method which let our clowns describe themself
        public string Name;
        public int Height;

        public void TalkAboutYourSelf()
        {
            MessageBox.Show("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu", Name + " mówi.."); //Message containing our variables like Name and Heigh. 
        }

    }

}
