using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAF_app2
{
    public partial class UserControl_Params : UserControl
    {
        private static UserControl_Params _instance;
        public static UserControl_Params Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Params();
                return _instance;
            }
        }
        public UserControl_Params()
        {
            InitializeComponent();
        }

        private void UserControl_Params_Load(object sender, EventArgs e)
        {

        }
    }
}
