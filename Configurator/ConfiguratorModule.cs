﻿using Configurator.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Autofac;
using Prism.Autofac;

namespace Configurator
{
    public class ConfiguratorModule : IModule
    {
        private IRegionManager _regionManager;
        private ContainerBuilder _builder;

        public ConfiguratorModule(ContainerBuilder builder, IRegionManager regionManager)
        {
            _builder = builder;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _builder.RegisterTypeForNavigation<ViewA>();
        }
    }
}