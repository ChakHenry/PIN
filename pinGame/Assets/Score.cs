using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreTXT;
    public static int SC;
    public Text END_ScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        SC = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTXT.text = SC.ToString();
        END_ScoreUI.text = SC.ToString();
    }
}
