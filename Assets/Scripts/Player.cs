using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    public static float strength = 5f;
    public static float gravity = -9.81f;
    public static float tilt = 5f;
    public static Vector3 direction;
/*
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }
*/
    public static void move()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            direction = Vector3.up * strength;
//            SoundController.instance.PlayThisSound("wing");
        }

        // direction.y += gravity * Time.deltaTime;
        // transform.position += direction * Time.deltaTime;
    }
    private void Update()
    {
        
        
    }
/*
    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            SoundController.instance.PlayThisSound("hit");
            FindObjectOfType<GameManager>().GameOver();
        } else if (other.gameObject.CompareTag("Scoring")) {
            SoundController.instance.PlayThisSound("point");
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
*/
}
