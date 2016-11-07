using UnityEngine;
using System.Collections;

public class BattleMain : MonoBehaviour {

	void Start () {
        GameObject prefab = (GameObject)Resources.Load("Prefabs/GrassTile");
        GameObject stageObject = GameObject.FindWithTag("Stage");
        for (int i = 0; i < 7; i++) {
            for(int j = 0; j < 7; j++) {

                Vector3 tile_pos = new Vector3 (
                    0 + prefab.transform.localScale.x * i, 0, 0 + prefab.transform.localScale.z * j
                );

                if(prefab != null) {
                    GameObject instant_object = (GameObject)GameObject.Instantiate(prefab, tile_pos, Quaternion.identity);
                    instant_object.transform.parent = stageObject.transform;
                }
            }
        }
    }

	void Update () {
	
	}
}
