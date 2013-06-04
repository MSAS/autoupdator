using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoUpdator.Engine;

namespace AutoUpdator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var engine = new UpdateEngine();

            if (engine.IsUpdateAvailable)
            {
                engine.Update();
            }
        }
    }
}