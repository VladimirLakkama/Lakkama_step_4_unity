using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button5 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button5 = 5;

    public void onPress()
    {
        buttonNomberOne.text += button5.ToString();
    }

}
