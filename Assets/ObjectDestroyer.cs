using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {

    //UnityChanを入れる
    private GameObject unitychan;


    // Use this for initialization
    void Start () {

        //unityちゃんのgameobjectをとる
        unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {

        //unitychanより15m後ろの位置になったら
        if (this.transform.position.z < unitychan.transform.position.z - 5)
        {
            //GameObjectを破壊
            Destroy(this.gameObject);
        }

    }
}
