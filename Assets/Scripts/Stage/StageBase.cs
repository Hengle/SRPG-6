using UnityEngine;
using System.Collections;

public class StageBase : MonoBehaviour {
	void Start () {
    }

    void Update () {
        RaycastHit hit;
        Ray ray;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit)) {
            TileBase tile_base = hit.collider.GetComponent<TileBase>();
            tile_base.bColorState = true;
        }
    }
}
