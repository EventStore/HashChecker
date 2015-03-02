all: *.cs
	mcs -out:HashCheck.exe -unsafe *.cs
