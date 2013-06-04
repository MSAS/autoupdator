using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdator.Target
{
    public enum TargetState { Locked, Free, Missing };

    public interface ITarget
    {
        /// <summary>
        /// Local folder, Network Folder, HTTP, FTP, SSH and so on,
        /// </summary>
        string Type { get; set; }

        string Url { get; set; }

        IDictionary<string, Version> Files { get; }

        DateTime UpdatedOn { get; }

        TargetState State { get; }
    }
}