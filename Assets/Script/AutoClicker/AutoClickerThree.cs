using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerThree : MonoBehaviour
{
    public bool autoStepThree = false;

    void Update()
    {
        if (autoStepThree == false)
        {
            autoStepThree = true;
            StartCoroutine(autoStepThreeCount());
        }     
    }

    IEnumerator autoStepThreeCount () {
        if (GlobalStepOne.stepTwoCount >= 1) {
            GlobalStepOne.stepTwoCount -= 1;
            GlobalStepOne.stepThreeCount += 0.5 + 0.5 * GlobalStepOne.stepThreeLevel;
        } else if (GlobalStepOne.stepTwoCount > 0) {
            GlobalStepOne.stepThreeCount += (GlobalStepOne.stepTwoCount + 0.5 * GlobalStepOne.stepThreeLevel) / 2;
            GlobalStepOne.stepTwoCount = 0;
        }
        yield return new WaitForSeconds(5/UpgradeShop.autoLevelStepThreeCount);
        autoStepThree = false;
    }
}
