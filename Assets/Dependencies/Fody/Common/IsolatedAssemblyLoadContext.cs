using System.IO;
using System;

public class IsolatedAssemblyLoadContext
{
    AppDomain appDomain;

    public IsolatedAssemblyLoadContext()
    {
        var appDomainSetup = new AppDomainSetup
        {
            ApplicationBase = AssemblyLocation.CurrentDirectory,
        };
        appDomain = AppDomain.CreateDomain("Fody AppDomain", null, appDomainSetup);
    }

    public IInnerWeaver CreateInstanceFromAndUnwrap()
    {
        var assemblyFile = Path.Combine(AssemblyLocation.CurrentDirectory, "FodyIsolated.dll");
        var innerWeaver = (IInnerWeaver)appDomain.CreateInstanceFromAndUnwrap(assemblyFile, "InnerWeaver");
        #if(NETSTANDARD)
        innerWeaver.LoadContext = this;
        #endif
        return innerWeaver;
    }

    public void Unload()
    {
        AppDomain.Unload(appDomain);
    }
}