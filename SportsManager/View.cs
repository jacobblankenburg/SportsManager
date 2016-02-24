using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class View
    {
        public void ViewAll()
        {
            UserControls uc = new UserControls();
            uc.GetUserControl();
        }
        
    }
}
