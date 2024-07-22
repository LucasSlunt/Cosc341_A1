using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text MyscoreText;
    private int ScoreNumber;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
        MyscoreText.text = "Score: " + ScoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D collidee)
    {
        if (collidee.tag == "MyCoin")
        {
            ScoreNumber++;
            Destroy(collidee.gameObject);//destroy when the player touches the coin
            MyscoreText.text = "Score: " + ScoreNumber;
        }
        if (collidee.tag == "enemy" && ScoreNumber!= 0)
        {
            ScoreNumber--;
            MyscoreText.text = "Score: " + ScoreNumber;
        }
    }

}
