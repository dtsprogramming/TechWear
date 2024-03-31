using UnityEngine;

public class MaskObject : MonoBehaviour
{
    private SkinnedMeshRenderer smr;

    void Start()
    {
        smr = GetComponent<SkinnedMeshRenderer>();

        for (int i = 0; i < smr.materials.Length; i++)
        {
            smr.materials[i].renderQueue = 3002;
        }
    }

    private void Update()
    {
        smr = GetComponent<SkinnedMeshRenderer>();

        for (int i = 0; i < smr.materials.Length; i++)
        {
            smr.materials[i].renderQueue = 3002;
        }
    }
}
