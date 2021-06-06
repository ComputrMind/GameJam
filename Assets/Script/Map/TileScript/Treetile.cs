﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Treetile : Tile
{
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		if (go != null)
		{
			go.GetComponent<SpriteRenderer>().sortingOrder = -position.y * 2;
		}


		return base.StartUp(position, tilemap, go);
	}
#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/Treetile")]
	public static void CreateTile()
	{
		string path = EditorUtility.SaveFilePanelInProject("Save Treetile", "New Treetile", "asset", "Save treetile", "Assets");
		if (path == "")
		{
			return;
		}
		AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<Treetile>(), path);
	}
#endif
}
