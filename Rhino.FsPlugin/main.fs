namespace FsPlugin



//open Rhino

// the Plugin:
type FsPlugin () =  // don't set constructor private  for singelton  
    inherit Rhino.PlugIns.PlugIn()
    
    // Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    // class. DO NOT create instances of this class yourself. It is the
    // responsibility of Rhino to create an instance of this class.
    // <para>To complete plug-in information, please also see all PlugInDescription
    // attributes in AssemblyInfo.cs (you might need to click 
    // "Project" -> "Show All Files" to see it in the "Solution Explorer" window).
    
    // You can override methods here to change the plug-in behavior on
    // loading and shut down, add options pages to the Rhino _Option command
    // and mantain plug-in wide options in a document .
    // Singelton: http://stackoverflow.com/questions/2691565/how-to-implement-singleton-pattern-syntax
    static member val Instance = FsPlugin()
     
    

// the Command(s):
[<System.Runtime.InteropServices.Guid("replace with guid string")>]
type FsPluginCommand () = // calls for the command that starts sthe script editor
    inherit Rhino.Commands.Command()    
    static member val Instance = FsPluginCommand() // Singelton: http://stackoverflow.com/questions/2691565/how-to-implement-singleton-pattern-syntax
    // Rhino only creates one instance of each command class defined in a
    // plug-in, so it is safe to store a refence in a static property.
                    
    override this.EnglishName = "xxxxx" //The command name as it appears on the Rhino command line.
           
    override this.RunCommand (doc, mode)  =        
        // perform action...
        //...

        Rhino.Commands.Result.Success



