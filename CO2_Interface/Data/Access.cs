using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class Access
    {
        private Int32 id;
        private String name;
        private bool can_create;
        private bool can_delete;
        private bool can_config_alarm;
        private bool can_create_user;

        public Access(int id, string name, bool can_create, bool can_delete, bool can_config_alarm, bool can_create_user)
        {
            this.id = id;
            this.name = name;
            this.can_create = can_create;
            this.can_delete = can_delete;
            this.can_config_alarm = can_config_alarm;
            this.can_create_user = can_create_user;
        }
    }
}
