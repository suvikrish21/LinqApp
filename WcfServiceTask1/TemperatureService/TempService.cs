using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureService
{
    public partial class TempService : ServiceBase
    {
        ServiceHost svcHost = null;

        public TempService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (svcHost != null)
            {
                svcHost.Close();
            }

            svcHost = new ServiceHost(typeof(TempCFService));
            svcHost.Open();


        }

        protected override void OnStop()
        {

            if (svcHost != null)
            {
                svcHost.Close();
                svcHost = null;
            }
        }
    }
}
