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

    // weight value
    private const float WEIGHT_MIN = 0f;
    private const float WEIGHT_MAX = 100f;
    private const float WEIGHT_STEP = 2f;
    float value = WEIGHT_MIN;

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
            if (value < WEIGHT_MAX) {
                blendShape.SetBlendShapeWeight(ALL_JOY, value);
                value += WEIGHT_STEP;
            }
        }
        else if (isSour)
        {
            if (value < WEIGHT_MAX)
            {
                blendShape.SetBlendShapeWeight(EYE_EXTRA, value);
                blendShape.SetBlendShapeWeight(MTH_SORROW, value);
                blendShape.SetBlendShapeWeight(EYE_EXTRA_ON, value);
                value += WEIGHT_STEP;
            }
        }
        else
        {
            value = WEIGHT_MIN;
            blendShape.SetBlendShapeWeight(ALL_JOY, value);
            blendShape.SetBlendShapeWeight(EYE_EXTRA, value);
            blendShape.SetBlendShapeWeight(MTH_SORROW, value);
            blendShape.SetBlendShapeWeight(EYE_EXTRA_ON, value);
        }
    }

}
