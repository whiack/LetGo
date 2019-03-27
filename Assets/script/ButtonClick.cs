using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {

    public Material rainbow;
    public float force;

    public void OnMouseDown() {
        Debug.Log("clicked");
        float r = rainbow.color.r;
        float g = rainbow.color.g;
        float b = rainbow.color.b;
        float a = rainbow.color.a;

        r -= force;
        g += force;

        rainbow.SetColor("_Color", new Vector4(r, g, b, a));
    }
}
