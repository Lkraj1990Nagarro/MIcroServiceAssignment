using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserService.Data
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailId{get;set;}
    }
}
