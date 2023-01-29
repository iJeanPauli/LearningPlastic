using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOneButtonClick : MonoBehaviour
{
    public GameObject textBox;

    public void FirstButtonClick () {
        GlobalStepOne.stepOneCount += 0.5 + 0.5 * GlobalStepOne.stepOneLevel;
    }

    public void SecondButtonClick () {
        if (GlobalStepOne.stepOneCount >= 1) {
            GlobalStepOne.stepOneCount -= 1;
            GlobalStepOne.stepTwoCount += 0.5 + 0.5 * GlobalStepOne.stepTwoLevel;
        } else if (GlobalStepOne.stepOneCount > 0) {
            GlobalStepOne.stepTwoCount += (GlobalStepOne.stepOneCount + 0.5 * GlobalStepOne.stepTwoLevel) / 2;
            GlobalStepOne.stepOneCount = 0;
        }
    }
    
    public void ThirdButtonClick () {
        if (GlobalStepOne.stepTwoCount >= 1) {
            GlobalStepOne.stepTwoCount -= 1;
            GlobalStepOne.stepThreeCount += 0.5 + 0.5 * GlobalStepOne.stepThreeLevel;
        } else if (GlobalStepOne.stepTwoCount > 0) {
            GlobalStepOne.stepThreeCount += (GlobalStepOne.stepTwoCount + 0.5 * GlobalStepOne.stepThreeLevel) / 2;
            GlobalStepOne.stepTwoCount = 0;
        }
    }

    public void FourthButtonClick () {
        if (GlobalStepOne.stepThreeCount >= 1) {
            GlobalStepOne.stepThreeCount -= 1;
            GlobalStepOne.stepFourCount += 0.5 + 0.5 * GlobalStepOne.stepFourLevel;
        } else if (GlobalStepOne.stepThreeCount > 0) {
            GlobalStepOne.stepFourCount += (GlobalStepOne.stepThreeCount + 0.5 * GlobalStepOne.stepFourLevel) / 2;
            GlobalStepOne.stepThreeCount = 0;
        }
    }

    public void FifthButtonClick () {
        if (GlobalStepOne.stepFourCount >= 1) {
            GlobalStepOne.stepFourCount -= 1;
            GlobalStepOne.stepFiveCount += 0.5 + 0.5 * GlobalStepOne.stepFiveLevel;
        } else if (GlobalStepOne.stepFourCount > 0) {
            GlobalStepOne.stepFiveCount += (GlobalStepOne.stepFourCount + 0.5 * GlobalStepOne.stepFiveLevel) / 2;
            GlobalStepOne.stepFourCount = 0;
        }
    }

    public void collectMoney () {
        if (GlobalStepOne.stepFiveCount > 0) {
            GlobalStepOne.walletCount += GlobalStepOne.stepFiveCount * GlobalStepOne.pricePerKgCount;
            GlobalStepOne.stepFiveCount = 0;
        }
    }

    public void stepOneLevelUp () {
        if (GlobalStepOne.walletCount >= GlobalStepOne.stepOneLevelPrice && GlobalStepOne.stepOneLevel < 5) {
            GlobalStepOne.stepOneLevel += 1;
            GlobalStepOne.walletCount -= GlobalStepOne.stepOneLevelPrice;
            GlobalStepOne.stepOneLevelPrice += 100;
        }
    }

    public void stepTwoLevelUp () {
        if (GlobalStepOne.walletCount >= GlobalStepOne.stepTwoLevelPrice && GlobalStepOne.stepTwoLevel < 5) {
            GlobalStepOne.stepTwoLevel += 1;
            GlobalStepOne.walletCount -= GlobalStepOne.stepTwoLevelPrice;
            GlobalStepOne.stepTwoLevelPrice += 100;
        }
    }

    public void stepThreeLevelUp () {
        if (GlobalStepOne.walletCount >= GlobalStepOne.stepThreeLevelPrice && GlobalStepOne.stepThreeLevel < 5) {
            GlobalStepOne.stepThreeLevel += 1;
            GlobalStepOne.walletCount -= GlobalStepOne.stepThreeLevelPrice;
            GlobalStepOne.stepThreeLevelPrice += 100;
        }
    }

    public void stepFourLevelUp () {
        if (GlobalStepOne.walletCount >= GlobalStepOne.stepFourLevelPrice && GlobalStepOne.stepFourLevel < 5) {
            GlobalStepOne.stepFourLevel += 1;
            GlobalStepOne.walletCount -= GlobalStepOne.stepFourLevelPrice;
            GlobalStepOne.stepFourLevelPrice += 100;
        }
    }

    public void stepFiveLevelUp () {
        if (GlobalStepOne.walletCount >= GlobalStepOne.stepFiveLevelPrice && GlobalStepOne.stepFiveLevel < 5) {
            GlobalStepOne.stepFiveLevel += 1;
            GlobalStepOne.walletCount -= GlobalStepOne.stepFiveLevelPrice;
            GlobalStepOne.stepFiveLevelPrice += 100;
        }
    }
}
