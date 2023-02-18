using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD.DATA.EntityModels
{
    public class User : IExField
    {
        public Guid APK { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public bool IsActivated { get; set; }
        public bool IsDisabled { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string ExField01 { get; set; }
        public string ExField02 { get; set; }
        public string ExField03 { get; set; }
        public string ExField04 { get; set; }
        public string ExField05 { get; set; }
        public string ExField06 { get; set; }
        public string ExField07 { get; set; }
        public string ExField08 { get; set; }
        public string ExField09 { get; set; }
        public string ExField10 { get; set; }
    }
}
