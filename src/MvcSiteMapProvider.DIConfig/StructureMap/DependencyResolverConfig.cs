﻿using System;
using System.Web.Mvc;
using StructureMap;
using DI;
using DI.StructureMap.Registries;

internal class DependencyResolverConfig
{
    public static void Register(IDependencyInjectionContainer container)
    {
        // Reconfigure MVC to use Service Location

        // You will need to use DependencyResolver if there are hard references
        // to IDependencyResolver in your code somewhere (don't do that - it limits your options
        // and tightly couples your code to MVC!).
        DependencyResolver.SetResolver(new InjectableDependencyResolver(container));
    }
}