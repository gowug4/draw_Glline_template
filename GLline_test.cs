using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GLline_test : MonoBehaviour
{
    private Material lineMaterial; 
    public Color[] colors = new Color[6] { Color.blue, Color.cyan, Color.green, Color.magenta, Color.red, Color.yellow };

    void Awake()
    {
        lineMaterial = new Material(Shader.Find("Custom/GizmoShader"));
    }

    void OnPostRender()
    {
        GL.PushMatrix();
        lineMaterial.SetPass(0);
        GL.LoadOrtho();
        GL.Begin(GL.LINES);
        for (int i = 0; i < 12; i++)
        {
            GL.Color(colors[i % 6]);
            GL.Vertex3(0, i / 12f, 0);
            GL.Vertex3(1, i / 12f, 0);
        }
        GL.End();
        GL.PopMatrix();
    }

    void OnApplicationQuit()
    {
        DestroyImmediate(lineMaterial);
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
