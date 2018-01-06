using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuest : MonoBehaviour {
	List<Quest> quests=new List<Quest>();
	// Use this for initialization
	void Start () {

		TextAsset questdata = Resources.Load<TextAsset> ("info");
		string[] data = questdata.text.Split (new char[]{ '\n' });

		for (int i = 1; i < data.Length - 1; i++) {

			string[] row = data [i].Split (new char[]{ ',' });

			Quest q = new Quest ();
			q.FirstName = row [0];
			q.LastName = row [1];
			int.TryParse(row[2],out q.Age) ;
			q.Gender= row [3];
			q.Address = row [4];
			q.Color = row [5];
			q.Sports = row [6];
			q.Status = row [7];

			quests.Add(q);
		}
		foreach (Quest q in quests){
			Debug.Log(q.FirstName+" "+q.LastName+" "+q.Age+" "+q.Gender+" "+q.Address+" "+q.Color+" "+q.Sports+" "+q.Status);
		}

}
	// Update is called once per frame
	void Update () {

	}
}
