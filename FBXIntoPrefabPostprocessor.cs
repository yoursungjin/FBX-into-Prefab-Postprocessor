using UnityEngine;
using UnityEditor;
using System.Collections;


public class FBXIntoPrefabPostprocessor : AssetPostprocessor {

	static string FBX_FOLDER = "Assets/SJ/Models/FBX/";
	static string TEXTURE_FOLDER = "Assets/SJ/Models/Textures/";
	static string PREFAB_DEST_FOLDER = "Assets/SJ/Prefabs/";

	public static void OnPostprocessAllAssets(
		string[] importedAssets,
		string[] deletedAssets,
		string[] movedAssets,
		string[] movedFromAssetPaths)
	{
		foreach(string assetPath in importedAssets)
		{
			//Check if an asset has been imported in the folder we care about
			if (assetPath.IndexOf(FBX_FOLDER) == -1)
				continue;
			
			//Load the asset and check if it is a gameObject or not
			GameObject go = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;
			if (go == null)
				continue;

			//assign the corresponding texture
			go.GetComponent<Renderer>().sharedMaterial.mainTexture = AssetDatabase.LoadAssetAtPath(TEXTURE_FOLDER + go.transform.name + ".jpg" , typeof(Texture)) as Texture;

			PrefabUtility.CreatePrefab(PREFAB_DEST_FOLDER + go.transform.name + ".prefab", go);
		}
			
	}

}
