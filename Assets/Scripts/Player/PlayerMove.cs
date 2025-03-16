using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftrightSpeed = 4;
    public  float rightLimit = 5f;
    public  float leftLimit = -5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);
        //forward , z ekseninde pozitif gitmektir.
        //backward, z ekseninde negatif yönde gitmektir.
        if(Input.GetAxisRaw("Horizontal") < 0) // GetAxisRaw -1, 0, ve 1 döndürür.
        {
            if(this.gameObject.transform.position.x > leftLimit ) //platformdan disari cikmasin diye sinirlarimizi da ayarladik.
            {
            transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed  );
            }
            
        }
         if(Input.GetAxisRaw("Horizontal") > 0) // GetAxisRaw -1, 0, ve 1 döndürür.
        {
            if(this.gameObject.transform.position.x < rightLimit ) //platformdan disari cikmasin diye sinirlarimizi da ayarladik.
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftrightSpeed);
            }
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("carpisma");
    }
}
