using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStepOne : MonoBehaviour
{
    public static double stepOneCount;
    public static double stepOneLevel = 1;
    public static double stepOneLevelPrice = 100;
    public static double stepTwoCount;
    public static double stepTwoLevel = 1;
    public static double stepTwoLevelPrice = 100;
    public static double stepThreeCount;
    public static double stepThreeLevel = 1;
    public static double stepThreeLevelPrice = 100;
    public static double stepFourCount;
    public static double stepFourLevel = 1;
    public static double stepFourLevelPrice = 100;
    public static double stepFiveCount;
    public static double stepFiveLevel = 1;
    public static double stepFiveLevelPrice = 100;
    public static double pricePerKgCount = 25;
    public static double walletCount = 20000;
    public GameObject stepOneDisplay;
    public GameObject stepOneLevelDisplay;
    public GameObject stepOneLevelPriceDisplay;
    public GameObject stepTwoDisplay;
    public GameObject stepTwoLevelDisplay;
    public GameObject stepTwoLevelPriceDisplay;
    public GameObject stepThreeDisplay;
    public GameObject stepThreeLevelDisplay;
    public GameObject stepThreeLevelPriceDisplay;
    public GameObject stepFourDisplay;
    public GameObject stepFourLevelDisplay;
    public GameObject stepFourLevelPriceDisplay;
    public GameObject stepFiveDisplay;
    public GameObject stepFiveLevelDisplay;
    public GameObject stepFiveLevelPriceDisplay;
    public GameObject pricePerKgDisplay;
    public GameObject walletDisplay;
    public GameObject walletShopDisplay;
    public GameObject shopPanel;
    public GameObject infoPanel;
    public double internalStepOne;
    public double internalStepOneLevel;
    public double internalStepOneLevelPrice;
    public double internalStepTwo;
    public double internalStepTwoLevel;
    public double internalStepTwoLevelPrice;
    public double internalStepThree;
    public double internalStepThreeLevel;
    public double internalStepThreeLevelPrice;
    public double internalStepFour;
    public double internalStepFourLevel;
    public double internalStepFourLevelPrice;
    public double internalStepFive;
    public double internalStepFiveLevel;
    public double internalStepFiveLevelPrice;
    public double internalPricePerKg;
    public double internalWallet;

    public void openShop () {
        shopPanel.SetActive(true);
    }

    public void closeShop () {
        shopPanel.SetActive(false);
    }

    public void openInfo () {
        infoPanel.SetActive(true);
    }

    public void closeInfo () {
        infoPanel.SetActive(false);
    }

    void Update()
    {
        internalStepOne = stepOneCount;
        internalStepOneLevel = stepOneLevel;
        internalStepOneLevelPrice = stepOneLevelPrice;
        internalStepTwo = stepTwoCount;
        internalStepTwoLevel = stepTwoLevel;
        internalStepTwoLevelPrice = stepTwoLevelPrice;
        internalStepThree = stepThreeCount;
        internalStepThreeLevel = stepThreeLevel;
        internalStepThreeLevelPrice = stepThreeLevelPrice;
        internalStepFour = stepFourCount;
        internalStepFourLevel = stepFourLevel;
        internalStepFourLevelPrice = stepFourLevelPrice;
        internalStepFive = stepFiveCount;
        internalStepFiveLevel = stepFiveLevel;
        internalStepFiveLevelPrice = stepFiveLevelPrice;
        internalPricePerKg = pricePerKgCount;
        internalWallet = walletCount;
        stepOneDisplay.GetComponent<Text>().text = "Stap 1: " + Math.Round(internalStepOne, 2);
        stepOneLevelDisplay.GetComponent<Text>().text = "Level " + internalStepOneLevel;
        if (stepOneLevel == 5) {
            stepOneLevelPriceDisplay.GetComponent<Text>().text = "Uitverkocht!";
        } else {
            stepOneLevelPriceDisplay.GetComponent<Text>().text = internalStepOneLevelPrice + " Euro";
        }
        stepTwoDisplay.GetComponent<Text>().text = "Stap 2: " + Math.Round(internalStepTwo, 2);
        stepTwoLevelDisplay.GetComponent<Text>().text = "Level " + internalStepTwoLevel;
        if (stepTwoLevel == 5) {
            stepTwoLevelPriceDisplay.GetComponent<Text>().text = "Uitverkocht!";
        } else {
            stepTwoLevelPriceDisplay.GetComponent<Text>().text = internalStepTwoLevelPrice + " Euro";
        }
        stepThreeDisplay.GetComponent<Text>().text = "Stap 3: " + Math.Round(internalStepThree, 2);
        stepThreeLevelDisplay.GetComponent<Text>().text = "Level " + internalStepThreeLevel;
        if (stepThreeLevel == 5) {
            stepThreeLevelPriceDisplay.GetComponent<Text>().text = "Uitverkocht!";
        } else {
            stepThreeLevelPriceDisplay.GetComponent<Text>().text = internalStepThreeLevelPrice + " Euro";
        }
        stepFourDisplay.GetComponent<Text>().text = "Stap 4: " + Math.Round(internalStepFour, 2);
        stepFourLevelDisplay.GetComponent<Text>().text = "Level " + internalStepFourLevel;
        if (stepFourLevel == 5) {
            stepFourLevelPriceDisplay.GetComponent<Text>().text = "Uitverkocht!";
        } else {
            stepFourLevelPriceDisplay.GetComponent<Text>().text = internalStepFourLevelPrice + " Euro";
        }
        stepFiveDisplay.GetComponent<Text>().text = "Stap 5: " + Math.Round(internalStepFive, 2);
        stepFiveLevelDisplay.GetComponent<Text>().text = "Level " + internalStepFiveLevel;
        if (stepFiveLevel == 5) {
            stepFiveLevelPriceDisplay.GetComponent<Text>().text = "Uitverkocht!";
        } else {
            stepFiveLevelPriceDisplay.GetComponent<Text>().text = internalStepFiveLevelPrice + " Euro";
        }
        pricePerKgDisplay.GetComponent<Text>().text = Math.Round(pricePerKgCount, 2) + " euro per KG";
        walletShopDisplay.GetComponent<Text>().text = "Euro: " + Math.Round(internalWallet, 2);
        walletDisplay.GetComponent<Text>().text = "Euro: " + Math.Round(internalWallet, 2);
    }
}
