using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GlobalStateManager globalManager;
    //Spieler Parameter
    [Range(1, 2)]
    public int playerNumber = 1;
    public float moveSpeed = 3f;
    public bool canDropBombs = true;
    public bool canMove = true;
    public bool dead = false;
    public int points;

    //private int bombs = 2;


    public GameObject bombPrefab;


    private Rigidbody rigidBody;
    private Transform myTransform;
    private Animator animator;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        myTransform = transform;
        animator = myTransform.Find("PlayerModel").GetComponent<Animator>();
    }

    void Update()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        animator.SetBool("Walking", false);

        if (!canMove)
        {
            return;
        }

        if (playerNumber == 1)
        {
            UpdatePlayer1Movement();
        }
        else
        {
            UpdatePlayer2Movement();
        }
    }


    //Spieler 1 Controlling
    private void UpdatePlayer1Movement()
    {
        if (Input.GetKey(KeyCode.W))
        { //Hoch
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.A))
        { //Links
            rigidBody.velocity = new Vector3(-moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 270, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.S))
        { //Runter
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.D))
        { //Rechts
            rigidBody.velocity = new Vector3(moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 90, 0);
            animator.SetBool("Walking", true);
        }

        if (canDropBombs && Input.GetKeyDown(KeyCode.Space))
        { //Lege Bombe
            DropBomb();
        }
    }

    //Spieler 2 Controlling
    private void UpdatePlayer2Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { //Hoch
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        { //Links
            rigidBody.velocity = new Vector3(-moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 270, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        { //Runter
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        { //Rechts
            rigidBody.velocity = new Vector3(moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 90, 0);
            animator.SetBool("Walking", true);
        }

        if (canDropBombs && (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)))
        { //Lege Bombe
            DropBomb();
        }
    }



    private void DropBomb()
    {
        //if (bombPrefab)
        //{ //Bombs will be placed on the fields Mathf.RoundToInt()
        //    Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(myTransform.position.x),
        //    bombPrefab.transform.position.y, Mathf.RoundToInt(myTransform.position.z)),
        //    bombPrefab.transform.rotation);
        //    points = points - 3;
        //}
        //NACHFRAGEN!!!
        //UNGLEICH i UND NUR POSITIVE ZAHLEN

        //for (int i = 3; i <= 30; i = i + 3)
        //{
        //    if (points == i)
        //    {
        //        if (bombPrefab)
        //        { //Bombs will be placed on the fields Mathf.RoundToInt()
        //            Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(myTransform.position.x),
        //            bombPrefab.transform.position.y, Mathf.RoundToInt(myTransform.position.z)),
        //            bombPrefab.transform.rotation);
        //            points = points - 3;
        //        }
        //    }
        //    //if (points != i)
        //    //{
        //    //    if (bombPrefab)
        //    //    { //Bombs will be placed on the fields Mathf.RoundToInt()
        //    //        Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(myTransform.position.x),
        //    //        bombPrefab.transform.position.y, Mathf.RoundToInt(myTransform.position.z)),
        //    //        bombPrefab.transform.rotation);
        //    //        points = points - 3;
        //    //    }
        //    //}
        //}

        //for (uint i = 3; i <=30; i = i + 3)
        //{
        //    if(points <= i)
        //    {
        //        if (bombPrefab)
        //        { //Bomben werden genau in die Mitte der Felder platziert. 
        //            Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(myTransform.position.x),
        //            bombPrefab.transform.position.y, Mathf.RoundToInt(myTransform.position.z)),
        //            bombPrefab.transform.rotation);
        //            points = points - 3;
        //        }
        //    }
        //}
        //Wenn Punkt größer gleich 3 Dann lege bombe!

        if (points >= 3)
        {
            if (bombPrefab)
            { //Bomben werden genau in die Mitte der Felder platziert. 
                Instantiate(bombPrefab, new Vector3(Mathf.RoundToInt(myTransform.position.x),
                bombPrefab.transform.position.y, Mathf.RoundToInt(myTransform.position.z)),
                bombPrefab.transform.rotation);
                points -= 3;
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Explosion"))
        {
            Debug.Log("Spieler " + playerNumber + " wurde eliminiert!");
            dead = true;
            globalManager.PlayerDied(playerNumber);
            Destroy(gameObject);
        }
    }

    private void OnGUI()
    {
        if (playerNumber == 1)
        {
            GUI.contentColor = Color.red;
            GUI.Label(new Rect(20, 10, 100, 20), "Spieler 1 : " + points);
        }

        if (playerNumber == 2)
        {
            GUI.contentColor = Color.blue;
            GUI.Label(new Rect(635, 10, 200, 20), "Spieler 2 : " + points);
        }

    }
}
