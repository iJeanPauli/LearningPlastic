using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerFour : MonoBehaviour
{
    public bool autoStepFour = false;

    void Update()
    {
        if (autoStepFour == false)
        {
            autoStepFour = true;
            StartCoroutine(autoStepFourCount());
        }     
    }

    IEnumerator autoStepFourCount () {
        if (GlobalStepOne.stepThreeCount >= 1) {
            GlobalStepOne.stepThreeCount -= 1;
            GlobalStepOne.stepFourCount += 0.5 + 0.5 * GlobalStepOne.stepFourLevel;
        } else if (GlobalStepOne.stepThreeCount > 0) {
            GlobalStepOne.stepFourCount += (GlobalStepOne.stepThreeCount + 0.5 * GlobalStepOne.stepFourLevel) / 2;
            GlobalStepOne.stepThreeCount = 0;
        }
        yield return new WaitForSeconds(5/UpgradeShop.autoLevelStepFourCount);
        autoStepFour = false;
    }
}
