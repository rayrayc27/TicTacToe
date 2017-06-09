using UnityEngine;
using UnityEngine.UI;
public class onClick : MonoBehaviour {
	public Button button1;
	public GameObject x;
	public GameObject o;
	public GameObject checkTurn;
	public string turn;
	// Use this for initialization
	// o turn  = 20
	// x turn  = 40
	void Start () {
		turn = "o";
		Button btn = button1.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick(){
		Debug.Log("You have clicked the button!");
		if (checkTurn.transform.position.y == 20) {
			turn = "o";
		} else {
			turn = "x";
		}
		if (turn.Equals ("o")) {
			if (o.transform.position.y < 0) {
				o.transform.position = new Vector3 (o.transform.position.x, .5f, o.transform.position.z);
				checkTurn.transform.position = new Vector3 (checkTurn.transform.position.x, 40, checkTurn.transform.position.z);
			}
		} else {
			if (x.transform.position.y < 0) {
				x.transform.position = new Vector3 (x.transform.position.x, 1, x.transform.position.z);
				checkTurn.transform.position = new Vector3 (checkTurn.transform.position.x, 20, checkTurn.transform.position.z);
			}
		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
