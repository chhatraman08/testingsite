using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace test
{
    public class chat : Hub
    {
        static string s1="";
        public void onconn()
        {

        }
        public void Hello(string msg)
        {
            Clients.Others.hello(msg);
        }

        
        public void sendmsg(string s,string username)
        {
            s1 += "<div class='receivemsg'>" + s + "<span class='receiver'>" + username + "</span></div>";
            Clients.Others.receivemsg(s,username);
        }

        public void getall()
        {
            Clients.Caller.loadall(s1);
        }
    }
}