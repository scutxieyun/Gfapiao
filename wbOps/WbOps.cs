using System;
using System.Windows.Forms;
namespace wbOps
{
    public abstract class ISkInteract {
        public abstract bool IsInFPWnd();
        public abstract bool InsertTitle(String title);
        public abstract bool InsertAmount(String amount);
        public abstract HtmlWindow getActPage();
        public static ISkInteract create(WebBrowser wb) { return new SkNormalInteract(wb); }
    }
    public class SkNormalInteract : ISkInteract
    {
        WebBrowser wb;
        HtmlWindow act_page = null;
        public SkNormalInteract(WebBrowser _wb) {
            wb = _wb;
            wb.Url = new Uri("https://fp.gdltax.gov.cn");
        }

        override public bool InsertAmount(string amount)
        {

            SetField("kpxmsm", "餐费");
            return SetField("je", amount);
        }
        override public bool InsertTitle(string title)
        {
            return SetField("fkfMc", title);
        }

        override public bool IsInFPWnd()
        {
            act_page = getFPWnd();
            return act_page != null;
        }

        bool SetField(String field, String val) {
            if (act_page != null)
            {
                HtmlElement ediv = act_page.Document.GetElementById(field);
                if (ediv != null)
                {
                    ediv.InnerText = val;
                    return true;
                }
            }
            return false;
        }

        HtmlWindow getFPWnd() {
            for (int i = 0; i < wb.Document.Window.Frames.Count; i++) {
                if (wb.Document.Window.Frames[i] != null && wb.Document.Window.Frames[i].Name == "nrq") {
                    return wb.Document.Window.Frames[i];
                }
            }
            return null;
        }

        public override HtmlWindow getActPage()
        {
            return getFPWnd();
        }
    }

}
