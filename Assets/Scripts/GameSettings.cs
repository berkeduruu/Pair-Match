using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private int settingsSelectionCounter;
    public enum Pairs
    {
        none = 0,
        E10pairs = 10,
        E15pairs = 15,
        E20pairs = 20,
    }
    public enum Categories
    {
        none,
        vegetable,
        fruit,
    }
    struct Settings
    {
        public Categories category;
        public Pairs pair;
    }

    Settings setting;

    private void Start()
    {
        setting = new Settings();
        resetGameSettings();
    }

    public void setPairs(Pairs pair)
    {
        if (setting.pair == Pairs.none)
        {
            settingsSelectionCounter++;
        }
        setting.pair = pair;
    }

    public void setPairs(Categories category)
    {
        if (setting.category == Categories.none)
        {
            settingsSelectionCounter++;
        }
        setting.category = category;
    }

    public Pairs getPairNumber()
    {
        return setting.pair;
    }
    public Categories GetCategory()
    {
        return setting.category;
    }
    public void resetGameSettings()
    {
        setting.pair = Pairs.none;
        setting.category = Categories.none;
        settingsSelectionCounter = 0;
    }
}
