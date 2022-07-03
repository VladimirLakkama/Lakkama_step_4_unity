using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button4 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button4 = 4;

    public void onPress()
    {
        buttonNomberOne.text += button4.ToString();
    }

}
