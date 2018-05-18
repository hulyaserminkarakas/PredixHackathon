using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class DataController : MonoBehaviour {

	private string gameDataFileName = "example.json";

	void Start () {
		
	}
	

	void Update () {
		
	}

	private void LoadData(){
	
		string filePath = Path.Combine (Application.streamingAssetsPath, gameDataFileName);
	
		if (File.Exists (filePath)) {
		
			string dataAsJson = File.ReadAllText (filePath);
		//	Constructor loadedData = JsonUtility.FromJson<Constructor> (dataAsJson);

		
		}
	}
}
