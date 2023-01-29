using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtons : MonoBehaviour
{
    public GameObject textBox;
    public GameObject autoOne;
    public GameObject autoTwo;
    public GameObject autoThree;
    public GameObject autoFour;
    public GameObject autoFive;

    public void FirstItem () {
        if (GlobalStepOne.walletCount >= UpgradeShop.firstItemPrice && UpgradeShop.autoLevelStepOneCount < 5) {
            UpgradeShop.autoLevelStepOneCount += 1;
            GlobalStepOne.walletCount -= UpgradeShop.firstItemPrice;
            UpgradeShop.firstItemPrice += 150;
            autoOne.SetActive(true);
        }
    }

    public void SecondItem () {
        if (GlobalStepOne.walletCount >= UpgradeShop.secondItemPrice && UpgradeShop.autoLevelStepTwoCount < 5) {
            UpgradeShop.autoLevelStepTwoCount += 1;
            GlobalStepOne.walletCount -= UpgradeShop.secondItemPrice;
            UpgradeShop.secondItemPrice += 150;
            autoTwo.SetActive(true);
        }
    }

    public void ThirdItem () {
        if (GlobalStepOne.walletCount >= UpgradeShop.thirdItemPrice && UpgradeShop.autoLevelStepThreeCount < 5) {
            UpgradeShop.autoLevelStepThreeCount += 1;
            GlobalStepOne.walletCount -= UpgradeShop.thirdItemPrice;
            UpgradeShop.thirdItemPrice += 150;
            autoThree.SetActive(true);
        }
    }

    public void FourthItem () {
        if (GlobalStepOne.walletCount >= UpgradeShop.fourthItemPrice && UpgradeShop.autoLevelStepFourCount < 5) {
            UpgradeShop.autoLevelStepFourCount += 1;
            GlobalStepOne.walletCount -= UpgradeShop.fourthItemPrice;
            UpgradeShop.fourthItemPrice += 150;
            autoFour.SetActive(true);
        }
    }

    public void FifthItem () {
        if (GlobalStepOne.walletCount >= UpgradeShop.fifthItemPrice && UpgradeShop.autoLevelStepFiveCount < 5) {
            UpgradeShop.autoLevelStepFiveCount += 1;
            GlobalStepOne.walletCount -= UpgradeShop.fifthItemPrice;
            UpgradeShop.fifthItemPrice += 150;
            autoFive.SetActive(true);
        }
    }
}
