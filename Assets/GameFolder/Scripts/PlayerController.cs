using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    public Text scoreView;
    public Transform gameOver;
    public Animator anim;

    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start()
    {
        anim.enabled = false;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.velocity = Vector2.up * 8;
            anim.enabled = true;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AddScore"))
        {
            score++;
            scoreView.text = score.ToString();
        }
        if (collision.CompareTag("Pipe") || collision.CompareTag("Base"))
        {
            enabled = false;
            gameOver.gameObject.SetActive(true);
            Invoke(nameof(Pause), 0);
        }
    }
    void Pause()
    {
        Time.timeScale = 0;
    }
}
