using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hearth : MonoBehaviour
{
    public int _health;
    public int _numOfHearts;

    public Image[] _hearts;
    public Sprite _fullHeart;
    public Sprite _emptyHeart;


    void Update()
    {
       
        for (int i = 0; i < _hearts.Length; i++)
        {
            if(i < _health)
            {
                _hearts[i].sprite = _fullHeart;
            }
            else
            {
                _hearts[i].sprite = _emptyHeart;
            }
            
            if(i < _numOfHearts)
            {
                _hearts[i].enabled = true;
            }
            else
            {
                _hearts[i].enabled = false;
            }
        }
    }
}
