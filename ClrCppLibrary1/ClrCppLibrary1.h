#pragma once

using namespace System;

namespace ClrCppLibrary1 {
    __declspec(dllimport)
	public ref class ClrCppClass
	{
    public:
        static void saySomething() {
            Console::WriteLine("ClrCppClass: Hello from managed C++");
        }
	};
}
