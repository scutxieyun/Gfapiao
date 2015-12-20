using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GFapiaoClient
{
    class SysCfg
    {
        static public SysCfg create(String fn) {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(fn);
                return new SysCfg(doc);
            }
            catch (Exception e) {
                return null;
            }
        }
        public string pos_id {
            get {
                return _pos_id;
            }
        }
        String _pos_id;
        private SysCfg(XmlDocument doc) {
            XmlNode node = doc.SelectSingleNode("identity/pos_id");
            if(node != null) _pos_id = node.Value;
        }
    }
}
