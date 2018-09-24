using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduleMesh : MonoBehaviour {

    Mesh mesh;

    Vector3[] verticles;
    int[] triangles;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;

    }
    // Use this for initialization
    void Start () {
        MakeMeshData();
        UpdateMesh();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void MakeMeshData() {
        verticles = new Vector3[]{new Vector3(0,0,0), new Vector3(0, 0, 1) , new Vector3(1, 0, 0) , new Vector3(1, 0, 1) };

        triangles = new int[] { 0, 1, 2 ,2,1,3};
    }

    void UpdateMesh() {
        mesh.Clear();
        mesh.vertices = verticles;

        mesh.triangles = triangles;
    }
}
