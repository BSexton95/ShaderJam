using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlShaderChangeBehaviour : MonoBehaviour
{
    [SerializeField]
    private Material _swrilShader;

    [SerializeField]
    private GameObject _tvScreen;

    private void OnMouseDown()
    {
        _tvScreen.GetComponent<MeshRenderer>().material = _swrilShader;
        Debug.Log("Hit");
    }
}
