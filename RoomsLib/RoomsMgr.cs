using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RoomsLib
{
    public class RoomsMgr
    {

        static private Dictionary<String, Room> dict = new Dictionary<string, Room>();
        static public bool updateWithJson(String json) {
            try {
                Rooms rs = JsonUtility.FromJson<Rooms>(json);
                foreach (Room item in rs.rooms)
                {
                    if (dict.ContainsKey(item.name))
                    {
                        Room cache = null;
                        if (dict.TryGetValue(item.name, out cache))
                        {
                            cache.Update(item);
                        }
                        else
                        {
                            dict.Add(item.name, item);
                        }
                    }
                }
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
        static public Room getRoom(String name) {
            Room res = null;
            if (dict.TryGetValue(name, out res))
            {
                return res;
            }
            else {
                return null;
            }

        } 
    }



    [System.Serializable]
    public class Room
    {
        public string id;
        public string name;
        public string state;
        public string category;
        private bool updated = true;
        public string toString()
        {
            return string.Format("room id:{0:s} status:{1:s}", id, state);
        }
        public void Update(Room n)
        {
            if (n.name != this.name)
            {
                this.name = n.name;
                this.updated = true;
            }
            if (n.state != this.state)
            {
                this.state = n.state;
                this.updated = true;
            }
            if (n.category != this.category)
            {
                this.category = n.category;
                this.updated = true;
            }
        }
        public bool is_updated()
        {
            if (this.updated)
            {
                this.updated = false;
                return true;
            }
            return false;
        }
    }
    [System.Serializable]
    public class Rooms
    {
        public Room[] rooms;
        public string toString()
        {
            string res = "";
            foreach (Room r in rooms)
            {
                res += r.toString();
            }
            return rooms.Length.ToString() + res;
        }
    }

}
