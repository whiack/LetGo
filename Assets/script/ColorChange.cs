using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    private Material rainbow;
    public float rate;

    public MeshRenderer Renderer;

	// Use this for initialization
	void Start () {
        rainbow = Renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
        float r = rainbow.color.r;
        float g = rainbow.color.g;
        float b = rainbow.color.b;
        float a = rainbow.color.a;
        if (g > 0) {
            r = r + rate;
            g = g - rate;
        }

        else  {
            r = r - rate;
            g = g - rate;
            b = b - rate;
            a = a + rate;
        }

        Vector4 myColor = new Vector4(r, g, b, a);


        rainbow.SetColor("_Color", new Vector4(r, g, b, a));

        GameObject leaves = GameObject.FindGameObjectWithTag("Leaves");

        ParticleSystem.MainModule settings = leaves.GetComponent<ParticleSystem>().main;
        settings.startColor = new Color(r, g, b, a);
    }
}
