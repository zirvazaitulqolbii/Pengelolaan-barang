using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UASWEBAPP2001092017.Models
{
    public class EditRole
    {
        public EditRole()
        {
              Users = new List<string>();
        }
        public string Id { get; set; }
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}