using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellsShaderBehaviour : MonoBehaviour
{
    [SerializeField]
    private Material _cellShader;

    [SerializeField]
    private GameObject _tvScreen;

    private void OnMouseDown()
    {
        _tvScreen.GetComponent<MeshRenderer>().material = _cellShader;
        Debug.Log("Hit");
    }
}
