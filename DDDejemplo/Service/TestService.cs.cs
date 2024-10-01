using System;
using System.Threading.Tasks;
using Context;
using Repository;

namespace Service
{
    /// <summary>
    /// 
    /// </summary>
    public class TestService:ITestService
    {
        private readonly ITestRepository testRepository;
        public TestService(ITestRepository testRepository){
            this.testRepository = testRepository;
        }

        public Test getAll(){
            return testRepository.getAll();
        }
    }
}
