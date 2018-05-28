using UnityEngine;
using UnityEngine.UI;

public class DoorCode : MonoBehaviour ,IInteractive{

    [SerializeField]
    Text button;

    [SerializeField]
    Text code;

    [SerializeField]
    bool isEnter;

    [SerializeField]
    string codeString;

    [SerializeField]
    Door door;

    public void OnAction(GameObject player)
    {
        if (!isEnter)
        {
            if (code.text.Length < 4)
            {
                code.text += button.text;
            }
            else
            {
                code.text = button.text;
            }
        }
        else
        {
            if (codeString.Equals(code.text))
            {
                door.OpenDoor(true);
            }
            else
            {
                code.text = "";
            }
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
