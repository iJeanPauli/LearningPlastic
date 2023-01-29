using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerFive : MonoBehaviour
{
    public bool autoStepFive = false;

    void Update()
    {
        if (autoStepFive == false)
        {
            autoStepFive = true;
            StartCoroutine(autoStepFiveCount());
        }     
    }

    IEnumerator autoStepFiveCount () {
        if (GlobalStepOne.stepFourCount >= 1) {
            GlobalStepOne.stepFourCount -= 1;
            GlobalStepOne.stepFiveCount += 0.5 + 0.5 * GlobalStepOne.stepFiveLevel;
        } else if (GlobalStepOne.stepFourCount > 0) {
            GlobalStepOne.stepFiveCount += (GlobalStepOne.stepFourCount + 0.5 * GlobalStepOne.stepFiveLevel) / 2;
            GlobalStepOne.stepFourCount = 0;
        }
        yield return new WaitForSeconds(5/UpgradeShop.autoLevelStepFiveCount);
        autoStepFive = false;
    }
}
