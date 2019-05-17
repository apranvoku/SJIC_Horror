using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSelect : MonoBehaviour
{
    public Material DefaultMaterial;
    public GameObject Rook;
    public bool CorrectPieceSelected;
    public bool CorrectPieceSelectedPawn;
    public bool FirstSquareAchieved;
    // Start is called before the first frame update
    void Start()
    {
        CorrectPieceSelected = false;
        CorrectPieceSelectedPawn = false;
        FirstSquareAchieved = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        if(this.gameObject.transform.childCount!=0)
        {
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.red;
        }
        for (int i = 0; i < this.gameObject.transform.parent.childCount; i++)
        {
            if (this.gameObject.transform.parent.GetChild(i) != this.transform)
            {
                this.gameObject.transform.parent.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = this.gameObject.transform.parent.GetChild(i).gameObject.GetComponent<PieceSelect>().DefaultMaterial;
                if (this.gameObject.transform.parent.GetChild(i).transform.childCount != 0)
                {
                    this.gameObject.transform.parent.GetChild(i).transform.GetChild(0).GetComponent<MeshRenderer>().material = DefaultMaterial;
                }
            }
        }
        if(this.gameObject.name == "Rook")
        {
            Rook.GetComponent<PieceSelect>().CorrectPieceSelected = true;
            Rook.GetComponent<PieceSelect>().CorrectPieceSelectedPawn = false;
        }
        else if (this.gameObject.name == "Pawn")
        {
            Rook.GetComponent<PieceSelect>().CorrectPieceSelectedPawn = true;
            Rook.GetComponent<PieceSelect>().CorrectPieceSelected = false;
        }
        else
        {
            Rook.GetComponent<PieceSelect>().CorrectPieceSelected = false;
            Rook.GetComponent<PieceSelect>().CorrectPieceSelectedPawn = false;
        }
    }
}
