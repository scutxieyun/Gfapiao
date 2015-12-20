using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GFapiaoClient
{
    [XmlRoot("rpts")]
    public class FapiaoItems {
        [XmlElement("rpt")]
        public FapiaoEntity[] items { get; set; }
        public static FapiaoItems create(String xml_str) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FapiaoItems));
            try
            {
                FapiaoItems revc = (FapiaoItems)xmlSerializer.Deserialize(new StringReader(xml_str.Trim()));
                return revc;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
    public class FapiaoEntity
    {
        [XmlElementAttribute("geotable_id")]
        public string geotable_id
        { get; set; }
        [XmlElementAttribute("store_name")]
        public string store_name
        { get; set; }
        [XmlElementAttribute("position")]
        public string position
        { get; set; }
        [XmlElementAttribute("fapiao_title")]
        public string fapiao_title
        { get; set; }
        [XmlElementAttribute("amount")]
        public string amount
        { get; set; }
        [XmlElementAttribute("created_at")]
        public string created_at
        { get; set; }
        [XmlElementAttribute("status")]
        public string status
        { get; set; }
        [XmlAttribute("id")]
        public string id
        { get; set; }

    }
}
