using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoUpdator.Source;
using AutoUpdator.Target;

namespace AutoUpdator.Engine
{
    public class UpdateEngine
    {
        public bool IsUpdateEnabled
        {
            get
            {
                //TODO: get this from Config file

                return false;
            }
        }

        public bool IsUpdateAvailable
        {
            get
            {
                if (!IsUpdateEnabled) return false;

                var lastUpdate = Target.UpdatedOn;

                if (!Source.Check(lastUpdate)) return false;

                return true;
            }
        }

        public bool IsAutoUpdateEnabled
        {
            get
            {
                //TODO get from config file
                // DisableAutoUpdate

                return true;
            }
        }

        public void BackUp()
        {
        }

        public void FreeTheTarget()
        {
            // you may send a message to user to close the application

            // you may automatically closed the application
        }

        public string Update()
        {
            return "Updated";
        }

        public ITarget Target
        {
            get
            {
                // if 'TargetFolder' exists
                // else assume that the target folder is same as the current folder;

                // TODO
                return null;
            }
        }

        private ISource _Source = null;

        public ISource Source
        {
            get
            {
                // get url from the config file

                // http://downloads.m-sas.com/edualaya/library

                string resourceType = "file";

                // get the type from the url
                switch (resourceType.ToLower())
                {
                    case "file":
                        _Source = new FileSource();
                        break;

                    case "http":
                        _Source = new HttpSource();
                        break;
                }

                return _Source;
            }
        }
    }
}