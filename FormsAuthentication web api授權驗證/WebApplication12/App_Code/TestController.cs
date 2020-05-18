using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;

namespace Api
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        //測試API
        [HttpGet]
        [Route("live")]
        public List<Student> Live()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1001,
                    Name = "小明",
                    Zzz = "2"
                },
                new Student
                {
                    Id = 101,
                    Name = "小華"
                },
            };
        }
        
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zzz { get; set; }
    }
    public enum Identity
    {
        [Description("管理者")]
        Admin = 1,

        [Description("一般使用者")]
        User = 2,
    }
    
    
   
    
}

