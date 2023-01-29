using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerOne : MonoBehaviour
{
    public bool autoStepOne = false;

    void Update()
    {
        if (autoStepOne == false)
        {
            autoStepOne = true;
            StartCoroutine(autoStepOneCount());
        }     
    }

    IEnumerator autoStepOneCount () {
        GlobalStepOne.stepOneCount += 0.5 + 0.5 * GlobalStepOne.stepOneLevel;
        yield return new WaitForSeconds(5/UpgradeShop.autoLevelStepOneCount);
        autoStepOne = false;
    }
}
