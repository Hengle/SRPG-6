using UnityEngine;
using System.Collections;

public class TileBase : MonoBehaviour {

    private Color default_color;
    private Color select_color;

    protected Material _material;

    public bool bColorState;

    void Start () {
        _material = this.gameObject.GetComponent<Renderer>().material;
        default_color = _material.color;
        select_color = Color.magenta;
        bColorState = false;
	}
	
	void Update () {
        _material.color = default_color;
        if(bColorState) {
            bColorState = false;
            _material.color = select_color;
        }
	}
}
