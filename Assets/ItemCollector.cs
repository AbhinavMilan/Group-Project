using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int count = 0;
    public Text txt;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "cherry")
        {
            Destroy(col.gameObject);
            count++;
            txt.text = "Cherries: " + count.ToString();
        }
    }
}
