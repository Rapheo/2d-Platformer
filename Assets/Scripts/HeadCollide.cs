using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollide : MonoBehaviour

{
    public float speed = 0.5f;
    //float uplift = 6.0f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jumpers") {
            Debug.Log("hoisa");
            Transform platfromTransfrom = collision.gameObject.GetComponent<Transform>();
            Vector2 locations = new Vector2(platfromTransfrom.localPosition.x, platfromTransfrom.localPosition.y);

            Vector2 moveToLocation = new Vector2(platfromTransfrom.localPosition.x, platfromTransfrom.localPosition.y + 5f);

            while (locations != moveToLocation) {
            platfromTransfrom.localPosition = Vector2.MoveTowards(locations, moveToLocation, speed * Time.deltaTime);
            }
            platfromTransfrom.localPosition = Vector2.MoveTowards(moveToLocation, locations, speed * Time.deltaTime);
        }
    }
 /*           while (uplift != 1f) {
                platfromTransfrom.position = new Vector2(platfromTransfrom.position.x, platfromTransfrom.position.y + uplift * Time.deltaTime);
                uplift--;
            }
            while (uplift != 10f)
            {
                Debug.Log(uplift);
                platfromTransfrom.position = new Vector2(platfromTransfrom.position.x, platfromTransfrom.position.y - uplift * Time.deltaTime);
                uplift++;
                break;
            }*/
}
