using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace wbOps
{
    public abstract class ISkInteract {
        public abstract String GetServUrl();
        public abstract bool IsInFPWnd(System.Windows.Forms.WebBrowser wb);
        public abstract bool InsertTitle(System.Windows.Forms.WebBrowser wb, String title);
        public abstract bool InsertAmount(System.Windows.Forms.WebBrowser wb, String amount);
        public static ISkInteract create() { return new SkNormalInteract(); }
    }
    public class SkNormalInteract : ISkInteract
    {
        override public string GetServUrl()
        {
            return "https://fp.gdltax.gov.cn";
        }

        override public bool InsertAmount(WebBrowser wb, string amount)
        {
            return false;
        }

        override public bool InsertTitle(WebBrowser wb, string title)
        {
            return false;
        }

        override public bool IsInFPWnd(WebBrowser wb)
        {
            return false;
        }
    }

}
