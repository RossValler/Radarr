﻿using NzbDrone.Api.REST;
using NzbDrone.Core.Configuration;

namespace NzbDrone.Api.Config
{
    public class NetImportConfigResource : RestResource
    {
        public int NetImportSyncInterval { get; set; }
	public string ListSyncLevel { get; set; }
	public string ImportExclusions { get; set; }
    }

    public static class NetImportConfigResourceMapper
    {
        public static NetImportConfigResource ToResource(IConfigService model)
        {
            return new NetImportConfigResource
            {
                NetImportSyncInterval = model.NetImportSyncInterval,
		ListSyncLevel = model.ListSyncLevel,
		ImportExclusions = model.ImportExclusions,
            };
        }
    }
}
