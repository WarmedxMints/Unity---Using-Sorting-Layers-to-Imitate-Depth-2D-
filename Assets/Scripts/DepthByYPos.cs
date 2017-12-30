using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthByYPos : MonoBehaviour {

    private const int DepthPerYUnit = 100;
    [SerializeField]
    private Renderer _renderer;

    public void Update()
    {
        _renderer.sortingOrder = -(int)(transform.position.y * DepthPerYUnit);
    }
}
