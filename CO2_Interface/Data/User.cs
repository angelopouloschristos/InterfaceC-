using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class User
    {
        public Int32 id;
        public string name;
        public string password;
        public Int32 access_id;

        public User(Int32 id, string name, string password, Int32 access_id)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.access_id = access_id;
        }

        public Int32 getId() { return this.id; }
        public string getName() { return this.name; }
        public string getPassword() { return this.password; }
        public Int32 getAccess_id() { return this.access_id; }

    }
}
