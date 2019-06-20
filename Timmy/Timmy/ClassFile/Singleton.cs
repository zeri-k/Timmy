using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timmy.Forms;

namespace Timmy.ClassFile
{
    static class Singleton
    {
        private static MainForm main;
        private static Animation ani;
        private static SetLoginForm settingForm;
        private static SetSiteForm listForm;
        
        static Singleton()
        {
            main = new MainForm();
            ani = new Animation();
            settingForm = new SetLoginForm();
            listForm = new SetSiteForm();
        }

        public static Form getMainInstance()
        {
            return main;
        }

        public static Form getAnimationInstance()
        {
            return ani;
        }

        public static Form getSettingFormInstance()
        {
            return settingForm;
        }

        public static Form getListFormInstance()
        {
            return listForm;
        }


    }
}
