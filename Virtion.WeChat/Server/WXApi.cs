﻿using Virtion.WeChat.Util;

namespace Virtion.WeChat.Server
{
    public class WxApi
    {
        public static string Server = "wx";//wx, wx2

        //login 
        public static string QrCodeUuidUrl = "https://login.wx.qq.com/jslogin?appid=wx782c26e4c19acffb&redirect_uri=http%3A%2F%2Fwx.qq.com%2Fcgi-bin%2Fmmwebwx-bin%2Fwebwxnewloginpage&fun=new&lang=zh_CN&_=" + Time.Now();

        public static string QrCodeImageUrl = "https://login.weixin.qq.com/qrcode/";

        public static string LoginUrl = "https://login.wx.qq.com/cgi-bin/mmwebwx-bin/login";

        //RPC
        public static string GetInitUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxinit";
            }
        }

        public static string SyncMsgUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxsync?";
            }
        }

        public static string GetDetailUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxbatchgetcontact?";
            }
        }

        public static string GetContactUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxgetcontact?";
            }
        }

        public static string DeleteMenberUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxupdatechatroom?fun=delmember";
            }
        }

        public static string SendMessageUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxsendmsg";
            }
        }

        public static string SyncCheckUrl
        {
            get
            {
                return "http://webpush." + Server + ".qq.com/cgi-bin/mmwebwx-bin/synccheck";
            }
        }

        public static string StatusNotifyUrl
        {
            get
            {
                return "https://" + Server + ".qq.com/cgi-bin/mmwebwx-bin/webwxstatusnotify";
            }
        }

        public static string GetAvatorUrl
        {
            get
            {
                return "http://" + Server + ".qq.com";
            }
        }

    }
}
