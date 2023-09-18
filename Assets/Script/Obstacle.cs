using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float Max = 0.5f;
    float Min = -0.5f;
    float delay = 0;
    float delayTime = 3;
    bool isTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isTop);
        if (!isTop)
        {
            if (transform.position.y >= Max)
            {
                delay += Time.deltaTime;
                if(delay >= delayTime)
                {
                    Debug.Log("1");
                    delay -= delayTime;
                    isTop = true;
                }
            }
            else
                transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        {
            if(transform.position.y <= Min) 
            {
                delay += Time.deltaTime;
                if (delay >= delayTime)
                { 
                    delay -= delayTime;
                    isTop = false;
                }
            }
            else
                transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
