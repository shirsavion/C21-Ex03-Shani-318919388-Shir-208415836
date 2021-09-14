using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.Logic;
using System.Drawing;
using System.Threading;

namespace BasicFacebookFeatures
{
    internal class BackToLandingVisitor
    {
        private readonly List<Color> r_FadeRange = new List<Color> { Color.LightCyan, 
            Color.LightBlue, Color.LightSkyBlue, Color.DeepSkyBlue, Color.DodgerBlue, 
                Color.CornflowerBlue, Color.SlateGray };

        public void FadeAndGoToLandingPage(Form i_ToLeave)
        {
            if (i_ToLeave != null)
            {
                fadeOut(i_ToLeave);
                i_ToLeave.Close();
            }
            else
            {
                throw new ProgrammerMisuseException("Object is a null reference", "Form");
            }
        }

        private void fadeOut(Form i_ToFade)
        {
            colorsOppositeDir(i_ToFade);
            colorsOppositeDir(i_ToFade);
        }

        private void colorsOppositeDir(Form i_ToFade)
        {
            r_FadeRange.Reverse();
            foreach ( Color shade in r_FadeRange)
            {
                i_ToFade.BackColor = shade;
                i_ToFade.Refresh();
                Thread.Sleep(3);
            }
        }
    }
}
