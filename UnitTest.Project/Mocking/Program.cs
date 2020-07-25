using System;
using System.Collections.Generic;
using System.Text;

namespace UnitProject.Mocking
{
    public class Program
    {
        public void main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
