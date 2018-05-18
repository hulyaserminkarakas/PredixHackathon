using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class Connection : MonoBehaviour {

	Cost cost = new Cost ();
	string json;
	public string userid;
	public WWW www ;
	string LoginUrl = "http://azuredsprodservice.cloudapp.net/Cost/GetWhere?component=Engine&Maintenance_Date=2008-04-26";
	CostList costs;
	int size;

	void Start()
	{
		//string t = ""
		//cost = JsonUtility.FromJson<Cost>;
		/*LoginUrl += string.Format("?username={0}", userid);
		www = new WWW(LoginUrl);
		yield return www;
		*/


		userid = "{\"list\":" + DownloadText (LoginUrl) + "}";
		costs = JsonUtility.FromJson<CostList>(userid);
		size = costs.list.Count;

		Debug.Log (size);
		Debug.Log(costs.list [0].Component);
	}

	void Update(){
	/*	if (costs.list.Count > 0) {
			Debug.Log(costs.list [0].component);
		
		}*/

	}

	public static string DownloadText(string url)
	{
		var client = new WebClient();
		byte[] data = client.DownloadData(url);
		return client.Encoding.GetString(data);

	}

}
