using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader4Behaviour : MonoBehaviour
{
    [SerializeField]
    private Material _shader4Shader;

    [SerializeField]
    private GameObject _tvScreen;

    private void OnMouseDown()
    {
        _tvScreen.GetComponent<MeshRenderer>().material = _shader4Shader;
        Debug.Log("Hit");
    }
}
