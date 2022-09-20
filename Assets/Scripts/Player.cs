using UnityEngine;

public class Player : Controller
{
    private GameObject PlayeTag;
    private void Awake()
    {
        PlayeTag = GameObject.FindWithTag("Player");
        GetSpriteRender();
    }
    private void Start()
    {
        RepeatingAnimate();
    }
    private void Update()
    {
        BirdMove();
    }
//Cho nguoi cho co the dieu khien
    public float strength = 5f;
    public float gravity = -9.81f;
    public float tilt = 5f;
    private Vector3 direction;

    //Cho chim co the bay
    private void BirdMove()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            direction = Vector3.up * strength;
            SoundController.instance.PlayThisSound("wing");
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
//Reset lai vi tri cua chim
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
        //Luu diem
        // FindObjectOfType<Controller>().Achievements();
    }
//Khi hai vat the va cham thi ham nay se duoc goi
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            SoundController.instance.PlayThisSound("hit");
            FindObjectOfType<Controller>().GameOver();
        } else if (other.gameObject.CompareTag("Scoring")) {
            SoundController.instance.PlayThisSound("point");
            FindObjectOfType<Controller>().IncreaseScore();
        }
    }
}