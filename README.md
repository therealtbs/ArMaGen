ArMaGen
=======
<b>Ar</b>tifact <b>Ma</b>nifest <b>Gen</b>erator is a small tool that produces small JSON-files about CI build artifacts.

ArMaGen saves this data in a file called `artifacts.json`
```json
{"artifacts":["ArMaGen.exe"]}
``` 
This is the file directly taken from my CI-Server.

You would invoke ArMaGen like this:
```
ArMaGen.exe [SearchPattern]
```
Where [SearchPattern] can use wildcards (*)

Builds
------
For now you can download ArMaGen right [here](http://builds.therealtbs.me/ArMaGen/25/ArMaGen.exe)
