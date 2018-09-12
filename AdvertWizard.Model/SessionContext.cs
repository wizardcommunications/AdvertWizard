using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertWizard.Model
{
    public class SessionContext
    {
        public long OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string ConnectionString { get; set; }
        public string StoragePath { get; set; }
        public string Logo { get; set; }
        public long? OperatingUnitId { get; set; }
        public string OperatingUnitName { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public List<RoleUserMapping> Roles { get; set; }
        public List<Menus> Menus { get; set; }
        public List<Actions> Actions { get; set; }
        //public string Token { get; set; }
    }

    public class Menus
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
    }

    public class Actions
    {
        public int ActionId { get; set; }
        public int MenuId { get; set; }
        public string ActionName { get; set; }
    }
}
