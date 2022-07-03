using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button9 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button9 = 9;

    public void onPress()
    {
        buttonNomberOne.text += button9.ToString();
    }

}
