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
    public partial class ObservantPictureBox : PictureBox, IObserver
    {
        public ObservantPictureBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void UpdateByState(bool i_StateOn)
        {
            this.Visible = !(i_StateOn);
        }
    }
}
