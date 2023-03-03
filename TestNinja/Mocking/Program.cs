using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
