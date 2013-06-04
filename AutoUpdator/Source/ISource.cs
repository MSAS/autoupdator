using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdator.Source
{
    public interface ISource
    {
        /// <summary>
        /// Local folder, Network Folder, HTTP, FTP, SSH and so on,
        /// </summary>
        string Type { get; set; }

        string Url { get; set; }

        IDictionary<string, Version> Files { get; }

        DateTime UpdatedOn { get; }

        /// <summary>
        /// Lets user know what has been added in this release
        /// </summary>
        string Description { get; }

        bool Check(DateTime lastUpdate);

        string InformationLink { get; }

        string DirectDownloadLink { get; }
    }
}