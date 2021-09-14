using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookApp;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormPhotoIcons : Form
    {
        private readonly FacadeManager r_Manager;
        private FormAlbumsPhotos m_childForm;
    }
}
