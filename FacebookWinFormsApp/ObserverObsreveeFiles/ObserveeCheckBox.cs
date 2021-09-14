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
    public partial class ObserveeCheckBox : CheckBox, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public ObserveeCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            notify();
        }

        private void notify()
        {
            if (observers.Count > 0)
            {
                foreach (IObserver observer in observers)
                {
                    observer.UpdateByState(this.Checked);
                }
            }
        }

        public void Attach(IObserver i_Observer)
        {
            observers.Add(i_Observer);
        }
        
        public void Detach(IObserver i_Observer)
        {
            observers.Remove(i_Observer);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            notify();
        }


    }
}
