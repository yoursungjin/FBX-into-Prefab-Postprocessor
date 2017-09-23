# FBX-into-prefab postprocessor
Unity asset postprocessor script that automatically turns fbx files into prefabs while importing them.

## Background
In Unity3D, there’s a situation where one has to import so many assets, say, more than a hundred ones,<br>
at the same time, wanting to manipulate them in the same way.<br>
<br>
For example, you may want to import a fbx file as a game objects and assign a corresponding texture to it,<br>
eventually making it as a prefab.<br>
Even though the procedure you want it to get through is pretty simple,<br>
applying the same procedure manually to all of them may be a formidable task.<br>
<br>
By subclassing [AssetPostProcessor](https://docs.unity3d.com/ScriptReference/AssetPostprocessor.html), however, they can be handled easily,<br>
automatically being converted into what you want them to be.<br>

## How to use
Place the script in an 'Editor' folder.

## Author
Sungjin Lee<br> 
sungjinlee0417@gmail.com
