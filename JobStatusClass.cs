using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAF_app2
{
    class JobStatusClass
    {

        private static JobStatusClass _instance;

        private JobStatusClass()
        {
        
        }

        public static JobStatusClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JobStatusClass();
                }
                return _instance;
            }
        }
        



        public string Name { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
    }

}
