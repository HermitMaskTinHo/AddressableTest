using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAddress : MonoBehaviour
{
    public AssetReference m_cube;
    // Start is called before the first frame update
    void Start()
    {
        m_cube.InstantiateAsync(Vector2.zero,Quaternion.identity);
    }
}
