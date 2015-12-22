using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WndInteract;
namespace GFapiaoClient
{
    static class NewShuiKongInterface
    {
        static int status;
        public static int init() {
            ScriptExecuter.init();
            status = -1;
            if(ScriptExecuter.readScript("chedaoshuikong_cfg.txt") != true) return -1;
            status = 0;
            return 0;
        }
        public static int SendRecipt(Dictionary <String,String> vpairs) {
            if (status != 0) { return -1; }
            Dictionary<String, String> rec = new Dictionary<string, string>();
            rec.Add("Customer_Text",vpairs["Customer_Text"]);
            rec.Add("Product_Code", vpairs["Product_Code"]);
            rec.Add("Product_Price", vpairs["Product_Price"]);
            rec.Add("Amount", vpairs["Amount"]);
            rec.Add("Product_Number", vpairs["Product_Number"]);
            rec.Add("Product_Type", vpairs["Product_Type"]);
            rec.Add("Pump_Number", vpairs["Pump_Number"]);
            return ScriptExecuter.execute(rec);
        }
        public static string getLastError() {
            return ScriptExecuter.getLastError();
        }
    }
}
