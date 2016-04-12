using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCManager.Data.DataServices;

namespace OCManager.Business
{
    public class TestBusiness
    {
        public void InitializeDB()
        {
            TestData td = new TestData();
            td.InitializeDBSet();
            
        }
    }
}
