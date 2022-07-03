using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button2 = 2;

    public void onPress()
    {
        buttonNomberOne.text += button2.ToString();
    }

}
