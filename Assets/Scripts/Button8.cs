using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button8 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button8 = 8;

    public void onPress()
    {
        buttonNomberOne.text += button8.ToString();
    }

}
