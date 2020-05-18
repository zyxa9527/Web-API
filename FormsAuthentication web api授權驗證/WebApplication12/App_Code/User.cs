using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12.App_Code
{
    public class User
    {
        //流水號
        public int Id { get; set; }
        //帳號
        public string UserId { get; set; }
        //名稱
        public string UserName { get; set; }
        //身分
        public Identity Identity { get; set; }
    }
}