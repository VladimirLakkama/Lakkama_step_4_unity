using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button3 = 3;

    public void onPress()
    {
        buttonNomberOne.text += button3.ToString();
    }

}
