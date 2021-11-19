using UnityEngine;

public class backSpawner : MonoBehaviour
{    // Update is called once per frame

    public GameObject backImage;    
    void Update()
    {
        if(backImage.transform.position.x < -18.8) {
            backImage.transform.position = new Vector3(19.1f, 0f, 0f);
        }
    }
}
