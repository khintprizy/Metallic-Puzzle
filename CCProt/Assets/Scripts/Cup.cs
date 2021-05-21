using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public GameObject[] outside;
    public int howManyOutside;
    private int outsideReady;

    [SerializeField] Transform goOut;

    public int ballCount;

    public Vector2[] slotArray;

    public int redBallCount;
    public int greenBallCount;
    public int blueBallCount;
    public int yellowBallCount;
    public int purpleBallCount;
    public int orangeBallCount;
    public int whiteBallCount;
    public int petrolBallCount;

    private bool isClickable;

    // Start is called before the first frame update
    void Start()
    {
        ballCount = 0;
        isClickable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady && 
            GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady && 
            GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady && 
            GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady && 
            GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady &&
            GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady &&
            GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady &&
            GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady)
        {
            isClickable = false;
        }
        if (!GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady || 
            !GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady || 
            !GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady || 
            !GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady || 
            !GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady ||
            !GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady ||
            !GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady ||
            !GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady)
        {
            isClickable = true;
        }
    }

    private void OnMouseDown()
    {
        if (isClickable)
        {
            for (int i = 0; i < howManyOutside; i++)
                if (outside[i].transform.childCount < 1)
                {
                    outsideReady++;
                }

            if (transform.childCount > 0 && outsideReady > howManyOutside - 1)            //for (int i = 0; i < howManyOutside; i++)
            {
                Vibration.Vibrate(50);
                GameObject selectedBall = transform.GetChild(ballCount - 1).gameObject;
                selectedBall.transform.position = goOut.position;
            }
            outsideReady = 0;

            for (int i = 0; i < howManyOutside; i++)
                if (outside[i].transform.childCount > 0)
                {
                    if (transform.childCount > 0)
                    {
                        if (transform.GetChild(transform.childCount - 1).gameObject.tag == outside[i].transform.GetChild(0).gameObject.tag)
                        {
                            Vibration.Vibrate(50);
                            GameObject selectedBall = outside[i].transform.GetChild(0).gameObject;
                            selectedBall.transform.position = slotArray[ballCount];
                        }
                    }
                    else
                    {
                        Vibration.Vibrate(50);
                        GameObject selectedBall = outside[i].transform.GetChild(0).gameObject;
                        selectedBall.transform.position = slotArray[ballCount];
                    }
                }

                else
                {
                    Debug.Log("NO CHILD");
                }
        }

        


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedBall"))
        {
            redBallCount++;
            if (redBallCount == slotArray.Length)
            {
                Debug.Log("red balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady = false;
            }
        }
        if (collision.gameObject.CompareTag("GreenBall"))
        {
            greenBallCount++;
            if (greenBallCount == slotArray.Length)
            {
                Debug.Log("green balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady = false;
            }
        }
        if (collision.gameObject.CompareTag("BlueBall"))
        {
            blueBallCount++;
            if (blueBallCount == slotArray.Length)
            {
                Debug.Log("blue balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady = false;
            }
            
        }
        if (collision.gameObject.CompareTag("YellowBall"))
        {
            yellowBallCount++;
            if (yellowBallCount == slotArray.Length)
            {
                Debug.Log("yellow balls are ready");
                GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady = false;
            }

        }
        if (collision.gameObject.CompareTag("PurpleBall"))
        {
            purpleBallCount++;
            if (purpleBallCount == slotArray.Length)
            {
                Debug.Log("purple balls are ready");
                GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady = false;
            }

        }
        if (collision.gameObject.CompareTag("OrangeBall"))
        {
            orangeBallCount++;
            if (orangeBallCount == slotArray.Length)
            {
                Debug.Log("orange balls are ready");
                GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady = false;
            }

        }
        if (collision.gameObject.CompareTag("WhiteBall"))
        {
            whiteBallCount++;
            if (whiteBallCount == slotArray.Length)
            {
                Debug.Log("white balls are ready");
                GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady = false;
            }

        }
        if (collision.gameObject.CompareTag("PetrolBall"))
        {
            petrolBallCount++;
            if (petrolBallCount == slotArray.Length)
            {
                Debug.Log("petrol balls are ready");
                GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady = false;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedBall"))
        {
            redBallCount--;
            if (redBallCount == slotArray.Length)
            {
                Debug.Log("red balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isRedReady = false;
            }
        }
        if (collision.gameObject.CompareTag("GreenBall"))
        {
            greenBallCount--;
            if (greenBallCount == slotArray.Length)
            {
                Debug.Log("green balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isGreenReady = false;
            }
        }
        if (collision.gameObject.CompareTag("BlueBall"))
        {
            blueBallCount--;
            if (blueBallCount == slotArray.Length)
            {
                Debug.Log("blue balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isBlueReady = false;
            }
        }
        if (collision.gameObject.CompareTag("YellowBall"))
        {
            yellowBallCount--;
            if (yellowBallCount == slotArray.Length)
            {
                Debug.Log("yellow balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isYellowReady = false;
            }
        }
        if (collision.gameObject.CompareTag("PurpleBall"))
        {
            purpleBallCount--;
            if (purpleBallCount == slotArray.Length)
            {
                Debug.Log("purple balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isPurpleReady = false;
            }
        }
        if (collision.gameObject.CompareTag("OrangeBall"))
        {
            orangeBallCount--;
            if (orangeBallCount == slotArray.Length)
            {
                Debug.Log("orange balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isOrangeReady = false;
            }
        }
        if (collision.gameObject.CompareTag("WhiteBall"))
        {
            whiteBallCount--;
            if (whiteBallCount == slotArray.Length)
            {
                Debug.Log("white balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isWhiteReady = false;
            }
        }
        if (collision.gameObject.CompareTag("PetrolBall"))
        {
            petrolBallCount--;
            if (petrolBallCount == slotArray.Length)
            {
                Debug.Log("petrol balls are done");
                GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady = true;

            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().isPetrolReady = false;
            }
        }
    }

}
