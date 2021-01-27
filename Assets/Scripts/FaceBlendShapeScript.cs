using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBlendShapeScript : MonoBehaviour
{
    private SkinnedMeshRenderer blendShape;

    // Blend Shape Number
    private const int ALL_JOY = 2;
    private const int EYE_EXTRA = 20;
    private const int MTH_SORROW = 27;
    private const int EYE_EXTRA_ON = 40;


    // Start is called before the first frame update
    void Start()
    {
        blendShape = this.GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJoy = Input.GetKey(KeyCode.J);
        bool isSour = Input.GetKey(KeyCode.K);
        if (isJoy) {
            float value = 0;
            for (int i = 0; i < 100; i++)
            {
                value = i;
                blendShape.SetBlendShapeWeight(ALL_JOY, value);
            }
        }
        else if (isSour)
        {
            float value = 0;
            for (int i = 0; i < 100; i++)
            {
                value = i;
                blendShape.SetBlendShapeWeight(EYE_EXTRA, value);
                blendShape.SetBlendShapeWeight(MTH_SORROW, value);
                blendShape.SetBlendShapeWeight(EYE_EXTRA_ON, value);
            }
        }
        else {
            float value = 0;
            blendShape.SetBlendShapeWeight(ALL_JOY, value);
            blendShape.SetBlendShapeWeight(EYE_EXTRA, value);
            blendShape.SetBlendShapeWeight(MTH_SORROW, value);
            blendShape.SetBlendShapeWeight(EYE_EXTRA_ON, value);
        }
    }

}
