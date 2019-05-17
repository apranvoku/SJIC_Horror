using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public GameObject Pawn;
    public GameObject Rook;
    public ChessTest ChessScript;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Rook.GetComponent<PieceSelect>().FirstSquareAchieved && Rook.GetComponent<PieceSelect>().CorrectPieceSelectedPawn)
        {
            StartCoroutine("PawnMove");
        }
    }

    IEnumerator PawnMove()
    {
        Vector3 differenceVector = this.transform.position - Pawn.transform.position;
        Vector3 PawnFlatPosition = Pawn.transform.position;
        Vector3 GoalFlatPosition = this.transform.position;
        PawnFlatPosition.y = 0;
        GoalFlatPosition.y = 0;
        differenceVector.y = 0;
        while ((PawnFlatPosition - GoalFlatPosition).sqrMagnitude > 0.0005f)
        {
            Pawn.transform.position += differenceVector / 100;
            PawnFlatPosition = Pawn.transform.position;
            GoalFlatPosition = this.transform.position;
            PawnFlatPosition.y = 0;
            GoalFlatPosition.y = 0;
            yield return null;
        }
        ChessScript.deactivateThis();
        GameObject.Find("Key").SetActive(true);
        timer.AddTime(60f);
        //Open the door here;
    }
}
