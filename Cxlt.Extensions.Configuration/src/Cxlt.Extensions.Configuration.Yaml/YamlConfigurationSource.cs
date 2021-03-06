﻿using System;
using Microsoft.Extensions.Configuration;

namespace Cxlt.Extensions.Configuration.Yaml
{
    internal class YamlConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new YamlConfigurationProvider(this);
        }
    }
}
