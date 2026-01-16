using UnityEngine;

public class Mover : MonoBehaviour
{
   public float speed = 0.02f;
   public float xMax;
   public float xMin;
   public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed * Time.deltaTime;
        transform.position = moverXPos;

        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;

        xMin = 0;

        if (xMax < screenTransformPosition.x)
        {
            speed *= -1;
        }
       
        if (xMin > screenTransformPosition.x)
        {
            speed *= -1;
        }

    }
}
