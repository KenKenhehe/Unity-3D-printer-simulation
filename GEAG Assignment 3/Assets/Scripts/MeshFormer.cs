using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFormer : MonoBehaviour
{
    public MeshFilter meshFilter;
    Vector3[] originalVertices;
    int[] originalTriangles;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        originalVertices = meshFilter.mesh.vertices;
        originalTriangles = meshFilter.mesh.triangles;
        meshFilter.mesh.vertices = new Vector3[originalVertices.Length];
        meshFilter.mesh.triangles = new int[originalTriangles.Length];
        for(int i = 0; i < meshFilter.mesh.vertices.Length - 20; i++)
        {
            meshFilter.mesh.vertices[i] = originalVertices[i];
        }
        for (int i = 0; i < meshFilter.mesh.triangles.Length - 20; i++)
        {
            meshFilter.mesh.triangles[i] = originalTriangles[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
