using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerTwo : MonoBehaviour
{
    public bool autoStepTwo = false;

    void Update()
    {
        if (autoStepTwo == false)
        {
            autoStepTwo = true;
            StartCoroutine(autoStepTwoCount());
        }     
    }

    IEnumerator autoStepTwoCount () {
        if (GlobalStepOne.stepOneCount >= 1) {
            GlobalStepOne.stepOneCount -= 1;
            GlobalStepOne.stepTwoCount += 0.5 + 0.5 * GlobalStepOne.stepTwoLevel;
        } else if (GlobalStepOne.stepOneCount > 0) {
            GlobalStepOne.stepTwoCount += (GlobalStepOne.stepOneCount + 0.5 * GlobalStepOne.stepTwoLevel) / 2;
            GlobalStepOne.stepOneCount = 0;
        }
        yield return new WaitForSeconds(5/UpgradeShop.autoLevelStepTwoCount);
        autoStepTwo = false;
    }
}
