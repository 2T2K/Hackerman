using UnityEngine;

public class TestOfCode : MonoBehaviour
{
    public static void MyMethod()
    {
        var col = new Color(Random.value, Random.value, Random.value, 1);
        var r = GameObject.Find("gem-1");
        var sprite = r.GetComponent<SpriteRenderer>();
        sprite.color = col;

        var positionX = Random.Range(1, 7);
        var positionY = Random.Range(-4, 4);

        var h = GameObject.Find("hearts-1");

        var moveX = h.transform.position.x;
        var moveY = h.transform.position.y;


        r.transform.position = new Vector2(positionX, positionY);
    }
}
