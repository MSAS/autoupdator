using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdator.Source
{
    internal class FileSource : ISource
    {
        #region ISource Members

        public string Type
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IDictionary<string, Version> Files
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime UpdatedOn
        {
            get { throw new NotImplementedException(); }
        }

        public string Description
        {
            get { throw new NotImplementedException(); }
        }

        #endregion ISource Members

        #region ISource Members

        public bool Check(DateTime lastUpdate)
        {
            throw new NotImplementedException();
        }

        public string InformationLink
        {
            get { throw new NotImplementedException(); }
        }

        public string DirectDownloadLink
        {
            get { throw new NotImplementedException(); }
        }

        #endregion ISource Members
    }
}