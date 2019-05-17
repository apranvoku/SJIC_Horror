using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public static int paintingNode;
    public string painting;
    public AudioClip correct;
    public AudioClip wrong;
    public Timer timer;
    private static bool notSolved;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        notSolved = true;
        paintingNode = 1;
        painting = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (notSolved)
        {
            switch (paintingNode)
            {
                case 1:
                    if (painting.Equals("George"))
                    {
                        paintingNode += 1;
                        AudioSource.PlayClipAtPoint(correct, transform.position);
                        //Play Correct ping sound;
                    }
                    else
                    {
                        paintingNode = 1;
                        AudioSource.PlayClipAtPoint(wrong, transform.position);
                        //Play Wrong pind sound;
                    }
                    break;
                case 2:
                    if (painting.Equals("John"))
                    {
                        paintingNode += 1;
                        AudioSource.PlayClipAtPoint(correct, transform.position);
                        //Play Correct ping sound;
                    }
                    else
                    {
                        paintingNode = 1;
                        AudioSource.PlayClipAtPoint(wrong, transform.position);
                        //Play Wrong pind sound;
                    }
                    break;
                case 3:
                    if (painting.Equals("Thomas"))
                    {
                        paintingNode += 1;
                        AudioSource.PlayClipAtPoint(correct, transform.position);
                        //Play Correct ping sound;
                    }
                    else
                    {
                        paintingNode = 1;
                        AudioSource.PlayClipAtPoint(wrong, transform.position);
                        //Play Wrong pind sound;
                    }
                    break;
                case 4:
                    if (painting.Equals("James1"))
                    {
                        paintingNode += 1;
                        AudioSource.PlayClipAtPoint(correct, transform.position);
                        //Play Correct ping sound;
                    }
                    else
                    {
                        paintingNode = 1;
                        AudioSource.PlayClipAtPoint(wrong, transform.position);
                        //Play Wrong pind sound;
                    }
                    break;
                case 5:
                    if (painting.Equals("James2"))
                    {
                        paintingNode += 1;
                        AudioSource.PlayClipAtPoint(correct, transform.position);
                        timer.AddTime(30);
                        StartCoroutine("WallDown");
                        notSolved = false;
                        //Play Correct ping sound;
                    }
                    else
                    {
                        paintingNode = 1;
                        AudioSource.PlayClipAtPoint(wrong, transform.position);
                        //Play Wrong pind sound;
                    }
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;

            }
        }
    }

    public IEnumerator WallDown()
    {
        int i = 0;
        while(i < 100)
        {
            wall.transform.position -= new Vector3(0f, 0.05f, 0f);
            i++;
            yield return null;
        }
    }
}
