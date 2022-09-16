using UnityEngine;

public class Pipes : MonoBehaviour
{
    private void Start()
    {
        GetLeftEdge();
    }
//Lay gia tri cua pham vi co the quan sat duoc
    public void GetLeftEdge()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
//Kiem tra xem cot da ra khoi pham vi co the quan sat va pha huy no
    public static float leftEdge;
    public float speed = 5f;
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        CheckPipes();
    }
    //Kiem tra cot da ra khoi pham vi co the quan sat chua
    public void CheckPipes()
    {     
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }

}
