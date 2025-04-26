using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerUI : MonoBehaviour
{
    public YAYA player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
             //обновазначенияздоровьяигрока
      healthSlider.maxValue = player.maxHealth;
      healthSlider.value = player.health;

      //обноватекстсколвоммонеток
      coinsCounterText.text = player.coins.ToString();  
         }
}
