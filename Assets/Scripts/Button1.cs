using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button1 = 1;

    public void onPress()
    {
        buttonNomberOne.text += button1.ToString();
    }

}
