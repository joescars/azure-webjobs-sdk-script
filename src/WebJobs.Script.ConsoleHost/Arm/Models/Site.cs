﻿using System.Collections.Generic;
using System.Globalization;

namespace WebJobs.Script.ConsoleHost.Arm.Models
{
    public class Site : BaseResource
    {
        private string _csmIdTemplate = "/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Web/sites/{2}";

        public override string ArmId
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, _csmIdTemplate, SubscriptionId, ResourceGroupName, SiteName);
            }
        }

        public string SiteName { get; private set; }

        public Dictionary<string, string> AppSettings { get; set; }

        public string HostName { get; set; }

        public string Location { get; set; }

        public string ScmUri { get; set; }

        public string PublishingUserName { get; set; }

        public string PublishingPassword { get; set; }

        public string ScmType { get; set; }

        public Site(string subscriptionId, string resourceGroupName, string name)
            : base(subscriptionId, resourceGroupName)
        {
            this.SiteName = name;
        }
    }
}