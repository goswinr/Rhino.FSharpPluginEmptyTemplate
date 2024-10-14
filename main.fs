namespace RhinoPlugin

open Rhino
open System
open System.Reflection

type RhinoPlugin () =  // don't set constructor private for singleton
    inherit PlugIns.PlugIn()

    static member val Instance = RhinoPlugin()


    override this.OnLoad(refErrs) : PlugIns.LoadReturnCode =
        let assemblies = AppDomain.CurrentDomain.GetAssemblies()
        for assembly in assemblies do
            if assembly.FullName.StartsWith "F" then
                RhinoApp.WriteLine(assembly.FullName)
        RhinoApp.WriteLine("RhinoPlugin loaded")

        PlugIns.LoadReturnCode.Success



type RhinoPluginCommand1 () =
    inherit Commands.Command()
    static member val Instance = RhinoPluginCommand1()

    override this.EnglishName = "RhinoPluginCommand1" //The command name as it appears on the Rhino command line.

    override this.RunCommand (doc, mode)  =
        let assemblies = AppDomain.CurrentDomain.GetAssemblies()
        for assembly in assemblies do
            if assembly.FullName.StartsWith "F" then
                RhinoApp.WriteLine(assembly.FullName)
        RhinoApp.WriteLine("Hello from RhinoPluginCommand1")

        Rhino.Commands.Result.Success



