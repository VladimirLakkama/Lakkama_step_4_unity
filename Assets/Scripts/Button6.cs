using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button6 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button6 = 6;

    public void onPress()
    {
        buttonNomberOne.text += button6.ToString();
    }

}
