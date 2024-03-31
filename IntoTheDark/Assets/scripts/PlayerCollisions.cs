using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    public static Vector2 lastcheckpoint = new Vector2((float)-8.82, (float)3.59);

    private void Awake() {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastcheckpoint;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            transform.position = lastcheckpoint;
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("end");
        }
    }


}
