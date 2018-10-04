all: build

clean:
	rm -rfv */bin */obj

build:
	msbuild /t:Restore -target:Clean,Build

run:
	mono ConsoleApp1/bin/Debug/netcoreapp2.1/ConsoleApp1.dll
