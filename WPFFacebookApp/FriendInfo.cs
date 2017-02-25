using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFFacebookApp
{
    public class FriendInfo
    {
        public struct Friend
        {
            public string name;
            public string id;
            public Friend(string name, string id)
            {
                this.name = name;
                this.id = id;
            }
        };

        public List<Friend> FriendList;
        public int FriendCount;

        public FriendInfo()
        {
            FriendList = new List<Friend>();
            FriendCount = 0;
        }
        public void Add(string name, string id)
        {
            Friend newFriend = new Friend(name, id);
            FriendList.Add(newFriend);
            FriendCount++;
        }
    }
}
