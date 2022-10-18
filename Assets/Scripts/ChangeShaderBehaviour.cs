using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaderBehaviour : MonoBehaviour
{
    [SerializeField]
    private Material _retroShader;
    [SerializeField]
    private Material _swirlShader;

    [SerializeField]
    private GameObject _tvScreen;
    
    private void OnMouseDown()
    {
        _tvScreen.GetComponent<MeshRenderer>().material = _retroShader;
        Debug.Log("Hit");
    }
}
