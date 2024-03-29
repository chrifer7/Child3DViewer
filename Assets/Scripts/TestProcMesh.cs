﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProcMesh : MonoBehaviour
{
    public float width = 50;
    public float height = 25;
    public float clones = 5;

    // Start is called before the first frame update
    void Start()
    {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            Debug.Log("ARG " + i + ": " + args[i]);
            if (args[i] == "-width")
            {
                width = float.Parse(args[i + 1]);
            }
            else if (args[i] == "-height")
            {
                height = float.Parse(args[i + 1]);
            }
            else if (args[i] == "-clones")
            {
                clones = float.Parse(args[i + 1]);
            }

        }

        MeshFilter mf = GetComponent<MeshFilter> ();
        var mesh = new Mesh();
        mf.mesh = mesh;

        Vector3[] vertices = new Vector3[4];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(width, 0, 0);
        vertices[2] = new Vector3(0, height, 0);
        vertices[3] = new Vector3(width, height, 0);

        mesh.vertices = vertices;

        int[] tri = new int[6];

        tri[0] = 0;
        tri[1] = 2;
        tri[2] = 1;

        tri[3] = 2;
        tri[4] = 3;
        tri[5] = 1;

        mesh.triangles = tri;

        Vector3[] normals = new Vector3[4];

        normals[0] = -Vector3.forward;
        normals[1] = -Vector3.forward;
        normals[2] = -Vector3.forward;
        normals[3] = -Vector3.forward;

        mesh.normals = normals;

        Vector2[] uv = new Vector2[4];

        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(1, 0);
        uv[2] = new Vector2(0, 1);
        uv[3] = new Vector2(1, 1);

        mesh.uv = uv;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
