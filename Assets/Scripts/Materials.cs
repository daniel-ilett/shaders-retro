using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materials : MonoBehaviour
{
    public MeshRenderer rend;
    public List<Material> materials;
    int index = 0;

    void Start()
    {
        InvokeRepeating("Swap", 2.0f, 4.0f);
    }

    private void Swap()
    {
        index++;

        if(index == materials.Count)
        {
            index = 0;
        }

        rend.material = materials[index];
    }
}
