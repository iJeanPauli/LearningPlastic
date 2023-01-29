using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour
{
    public static int autoLevelStepOneCount;
    public static int firstItemPrice = 150;
    public static int autoLevelStepTwoCount;
    public static int secondItemPrice = 150;
    public static int autoLevelStepThreeCount;
    public static int thirdItemPrice = 150;
    public static int autoLevelStepFourCount;
    public static int fourthItemPrice = 150;
    public static int autoLevelStepFiveCount;
    public static int fifthItemPrice = 150;
    public GameObject autoLevelStepOneDisplay;
    public GameObject firstItemPriceDisplay;
    public GameObject autoLevelStepTwoDisplay;
    public GameObject secondItemPriceDisplay;
    public GameObject autoLevelStepThreeDisplay;
    public GameObject thirdItemPriceDisplay;
    public GameObject autoLevelStepFourDisplay;
    public GameObject fourthItemPriceDisplay;
    public GameObject autoLevelStepFiveDisplay;
    public GameObject fifthItemPriceDisplay;
    public int internalAutoLevelStepOne;
    public int internalFirstItemPrice;
    public int internalAutoLevelStepTwo;
    public int internalSecondItemPrice;
    public int internalAutoLevelStepThree;
    public int internalThirdItemPrice;
    public int internalAutoLevelStepFour;
    public int internalFourthItemPrice;
    public int internalAutoLevelStepFive;
    public int internalFifthItemPrice;

    void Update()
    {
        internalAutoLevelStepOne = autoLevelStepOneCount;
        internalFirstItemPrice = firstItemPrice;
        internalAutoLevelStepTwo = autoLevelStepTwoCount;
        internalSecondItemPrice = secondItemPrice;
        internalAutoLevelStepThree = autoLevelStepThreeCount;
        internalThirdItemPrice = thirdItemPrice;
        internalAutoLevelStepFour = autoLevelStepFourCount;
        internalFourthItemPrice = fourthItemPrice;
        internalAutoLevelStepFive = autoLevelStepFiveCount;
        internalFifthItemPrice = fifthItemPrice;
        autoLevelStepOneDisplay.GetComponent<Text>().text = "Level: " + internalAutoLevelStepOne;
        if (autoLevelStepOneCount == 5) {
            firstItemPriceDisplay.GetComponent<Text>().text = "Uitverkocht";
        } else {
            firstItemPriceDisplay.GetComponent<Text>().text = internalFirstItemPrice + " euro";
        }
        autoLevelStepTwoDisplay.GetComponent<Text>().text = "Level: " + internalAutoLevelStepTwo;
        if (autoLevelStepTwoCount == 5) {
            secondItemPriceDisplay.GetComponent<Text>().text = "Uitverkocht";
        } else {
            secondItemPriceDisplay.GetComponent<Text>().text = internalSecondItemPrice + " euro";
        }
        autoLevelStepThreeDisplay.GetComponent<Text>().text = "Level: " + internalAutoLevelStepThree;
        if (autoLevelStepThreeCount == 5) {
            thirdItemPriceDisplay.GetComponent<Text>().text = "Uitverkocht";
        } else {
            thirdItemPriceDisplay.GetComponent<Text>().text = internalThirdItemPrice + " euro";
        }
        autoLevelStepFourDisplay.GetComponent<Text>().text = "Level: " + internalAutoLevelStepFour;
        if (autoLevelStepFourCount == 5) {
            fourthItemPriceDisplay.GetComponent<Text>().text = "Uitverkocht";
        } else {
            fourthItemPriceDisplay.GetComponent<Text>().text = internalFourthItemPrice + " euro";
        }
        autoLevelStepFiveDisplay.GetComponent<Text>().text = "Level: " + internalAutoLevelStepFive;
        if (autoLevelStepFiveCount == 5) {
            fifthItemPriceDisplay.GetComponent<Text>().text = "Uitverkocht";
        } else {
            fifthItemPriceDisplay.GetComponent<Text>().text = internalFifthItemPrice + " euro";
        }
    }
}
