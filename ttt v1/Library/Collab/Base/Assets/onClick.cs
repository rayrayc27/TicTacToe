using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onClick : MonoBehaviour {
	public Button button1;
	public GameObject x;
	// Use this for initialization
	void Start () {
		Button btn = button1.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick(){
		Debug.Log("You have clicked the button!");
		if (x.transform.position.y < 0) {
			x.transform.position = new Vector3 (x.transform.position.x, x.transform.position.y + 1, x.transform.position.z);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
