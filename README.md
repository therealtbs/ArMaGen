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
You can find the latest builds right [here](http://builds.therealtbs.me/#!ArMaGen)
