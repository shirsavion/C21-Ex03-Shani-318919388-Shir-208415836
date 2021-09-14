using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Logic.ObservantObservee;

namespace BasicFacebookFeatures.ObserverObsreveeFiles
{
    public partial class ObservantPanel : Panel, IObserver
    {
        // ISubject

        public ObservantPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void UpdateByState(bool i_StateOn)
        {
            this.BackColor = i_StateOn == false ? Color.FromArgb(64, 64, 64) : Color.Snow;
        }
    }
}
