all: build

clean:
	rm -rfv */bin */obj

build:
	msbuild /t:Restore -target:Clean,Build
