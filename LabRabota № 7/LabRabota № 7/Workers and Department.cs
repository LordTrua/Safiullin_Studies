using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota___7
{
    class Workers_and_Department
    {
        Department Dep; //Department id
        Workers Wor;// Worker id
        public Workers_and_Department(Workers W, Department De)
        {
            Wor = W;
            Dep = De;
        }
        public Workers get_W() { return this.Wor; }
        public Department get_D() { return this.Dep; }
    }
}
