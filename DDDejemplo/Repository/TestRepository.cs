using System;
using System.Data.Common;
using System.Threading.Tasks;
using Context;
using Repository;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestRepository:ITestRepository
    {
        public Test getAll(){
            var t1 = new Test();
            t1.id = 1;
            t1.test = "test";
            return t1;
        }
    }
}
