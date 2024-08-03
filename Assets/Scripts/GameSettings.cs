using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameSettings : MonoBehaviour
{
    public Button button10pair, button15pair, button20pair;
    public Button buttonVegetable, buttonFruit;
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
    private void Start()
    {

        button10pair.onClick.AddListener(() => setPairs(Pairs.E10pairs));
        button15pair.onClick.AddListener(() => setPairs(Pairs.E15pairs));
        button20pair.onClick.AddListener(() => setPairs(Pairs.E20pairs));

        buttonFruit.onClick.AddListener(() => setCategory(Categories.fruit));
        buttonVegetable.onClick.AddListener(() => setCategory(Categories.vegetable));
    }

    public void setPairs(Pairs pair)
    {
        PlayerPrefs.SetInt("SelectedPair", (int)pair);
        Debug.Log("Selected Pair: " + pair);
    }

    public void setCategory(Categories category)
    {
        PlayerPrefs.SetString("SelectedCategory", category.ToString());
        Debug.Log("Selected Category: " + category);
    }
    
}
