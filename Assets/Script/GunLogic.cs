using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GunLogic : MonoBehaviour
{
    public GameObject bullet;
    public int BulletDelay;
    private Transform shotSpawn;
    public GameObject BulletsLeft;
    public int BulletsLeftInt;
    public GameObject NoBullets;
    // Start is called before the first frame update
    void Start()
    {
        BulletDelay = 0;
        shotSpawn = this.transform.Find("BulletSpawnLocation").transform;
        BulletsLeftInt = 1;
        BulletsLeft.GetComponent<Text>().text = BulletsLeftInt.ToString();
        NoBullets.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (BulletDelay == 5f)
            {
                if (BulletsLeftInt > 0) {
                    NoBullets.SetActive(false);
                    Debug.Log("Uv Shot");
                    GameObject bullet1 = Instantiate(bullet, shotSpawn.transform.position, shotSpawn.rotation);
                    bullet1.GetComponent<Rigidbody>().AddForce(shotSpawn.forward * 10, ForceMode.Impulse);
                    Destroy(bullet1.gameObject, 3);
                    BulletDelay = 0;
                    BulletsLeftInt -= 1;
                    BulletsLeft.GetComponent<Text>().text = BulletsLeftInt.ToString();
                }else{
                    NoBullets.SetActive(true);
                }
            }




        }
        else
        {
            if (BulletDelay < 5)
            {
                BulletDelay += 1;
            }
        }
    }
    public void AddBullets(int amount)
    {
        BulletsLeftInt = BulletsLeftInt + amount;
        BulletsLeft.GetComponent<Text>().text = BulletsLeftInt.ToString(); 
    }
}
