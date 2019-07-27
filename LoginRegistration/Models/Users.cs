using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER MODEL***/
  [Table("users")]
 public partial class User : IMicron
 {
        [Primary]
        public Int32 Id {get; set;}
        public String FullName {get; set;}
        public String UserName {get; set;}
        public String Password {get; set;}
        public String Email {get; set;}
        public String Phone {get; set;}
        public String Gender {get; set;}
        public Boolean IsAdmin {get; set;}
 }
}
