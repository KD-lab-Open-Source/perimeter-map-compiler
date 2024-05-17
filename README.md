# Perimeter map compiler

## Building

**NOTE:** Tested on Visual Studio 2022

Clone this repository with submodules

### Building freeimage libarary

**This needed to be done once**

1. Open 3rdparty/freeimage/FreeImage.2017.sln in Visual Studio
2. Migrate project to your version of studio (if needed)
3. Select Build -> Batch Build...
4. Select **FreeImageLib / Debug / Win32** and **FreeImagePlus / Debug / Win32**
5. Press Build
6. Now you can close this project

### Building tinyxml/tinyxpath library

**This needed to be done once**

1. Open 3rdparty/tinyxpath/tinyxpath.sln in Visual Studio
2. Migrate project to your version of studio (if needed)
3. Select Build -> Batch Build...
4. Select **tinyxpath_lib / Debug / Win32**
5. Press Build
6. Now you can close this project

### Building perimeter-map-compiler

1. Open perimeter-map-compiler.sln in Vistual Studio 2022 (or greater)
2. Select Debug / x86
3. Build or Run


