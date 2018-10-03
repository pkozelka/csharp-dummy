using System;

namespace ClassLibrary1
{
    public class RemoteClass
    {
        public static void SaySomething()
        {
            Console.WriteLine("RemoteClass: Hello from a library");

            // call a c++ based functionality:

            /* crashes, saying:
             * System.TypeInitializationException: 'The type initializer for '<Module>' threw an exception.'
             * 1. ModuleLoadException: The C++ module failed to load.
             * 2. EntryPointNotFoundException: A library name must be specified in a DllImport attribute applied to non-IJW methods.
             * 
             * According to https://stackoverflow.com/questions/48958143/net-core-2-dll-reference-with-c-code-runtime-error ,
             * this is not possible in .NET Core: ".NET Core does not support C++/CLI ("Managed C++") and will fail to load such libraries."
             * 
             * So the next option might be, use .NET standard instead...
             */
            ClrCppLibrary1.ClrCppClass.saySomething();
        }
    }
}
