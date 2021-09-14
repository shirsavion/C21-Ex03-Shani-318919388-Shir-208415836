using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Runtime;
using FacebookApp;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public interface iPhotoIcons
    {
        void FetchChildrenAndIcons();

        void ShowChild(int i_IndexOfChosenChild, String I_ChildName);

        void Child_Clicked(object sender, EventArgs e);
    }
}
