using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float rootSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

       void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rootSpeed = Random.Range(1f, 100f);
        }

        transform.Rotate(0, 0, this.rootSpeed);

        this.rootSpeed *= 0.96f;
    }
}
