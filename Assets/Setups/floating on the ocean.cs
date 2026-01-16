using UnityEngine;

public class floatingontheocean : MonoBehaviour
{
    public float speed = 1.0f;
    public float duration;
    public AnimationCurve curve;
    public float yMax;
    public float yMin;

    public float output;
    private float progress = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // transform y position to osilate up and down
        Vector3 moverYPos = transform.position;
        moverYPos.y += speed * Time.deltaTime;
        transform.position = moverYPos;

        yMax = 0;

        yMin = 0;

        if (yMax < moverYPos.x - 10)
        {
            speed *= -1;
        }

        if (yMin > moverYPos.x)
        {
            speed *= -1;

           }
            // after the sprite finishes its movements it restarts

            progress += Time.deltaTime / duration;
        output = curve.Evaluate(progress);

        if (progress > 1f)
        {
            progress = 0f;

        }

    }
}
