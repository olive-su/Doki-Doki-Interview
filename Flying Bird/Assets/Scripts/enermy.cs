using UnityEngine;
using System.Collections;

public class enermy : MonoBehaviour
{
    //public GameObject enermy;
    public GameObject bubbleObj1, bubbleObj2, bubbleObj3, bubbleObj4;
    GameObject[] arrObj = new obj[4]{bubbleObj1, bubbleObj2, bubbleObj3, bubbleObj4};
    public float maxTime=5;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int oneShoting = 120;
        // int speed = 5;
        if(timer > maxTime) {
        // for(int i =0;i<oneShoting;i++) 
        // {
            // Debug.Log(i);
            float i = Random.Range(1, 120);
            GameObject bubble = Instantiate(arrObj[i % 4], transform.position, transform.rotation);
            Rigidbody2D rigid = bubble.GetComponent<Rigidbody2D>();
            Vector2 dirVec = new Vector2(1, Mathf.Sin(i));

            rigid.AddForce(dirVec.normalized * 30, ForceMode2D.Impulse); 
            // ForceMode2D.Impulse : 강하게 나가는 효과 위함
            rigid.transform.Rotate(new Vector3(0f,0f,i));
            // 물방울의 회전각을 어떻게 조절해야할까요?
            // 360*i/oneShoting -90
            Destroy(bubble, 20); // 물방울을 어떻게 없애야 하나요??
            timer = 0;
        }
        timer += 1;
    }
}
