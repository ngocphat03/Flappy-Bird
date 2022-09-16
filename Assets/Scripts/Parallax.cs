using UnityEngine;

public class Parallax : MonoBehaviour
{
//Lay hinh anh 360
    private MeshRenderer meshRenderer;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
//Lap lai hinh anh 360 duoi dang 2D
    public float animationSpeed = 1f;
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }

}
