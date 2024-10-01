using System;
using System.Threading.Tasks;
using Context;
using Microsoft.AspNetCore.Mvc;

using Service;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
    public class TestController
    {
        private readonly ITestService testService;
        public TestController(ITestService testService){
            this.testService = testService;
        }

        [HttpGet]

        public IActionResult getAll(){
            return (IActionResult)testService.getAll();
        }

    }
}
