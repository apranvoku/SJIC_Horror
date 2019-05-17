using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public GameObject Rook;
    public PawnTake Pawn;
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
        if(Rook.GetComponent<PieceSelect>().CorrectPieceSelected)
        {
            StartCoroutine("KnightMove");
        }
    }

    IEnumerator KnightMove()
    {
        Vector3 differenceVector = this.transform.position - Rook.transform.position;
        Vector3 KnightFlatPosition = Rook.transform.position;
        Vector3 GoalFlatPosition = this.transform.position;
        KnightFlatPosition.y = 0;
        GoalFlatPosition.y = 0;
        differenceVector.y = 0;
        while ((KnightFlatPosition - GoalFlatPosition).sqrMagnitude > 0.0005f)
        {
            Rook.transform.position += differenceVector / 100;
            KnightFlatPosition = Rook.transform.position;
            GoalFlatPosition = this.transform.position;
            KnightFlatPosition.y = 0;
            GoalFlatPosition.y = 0;
            yield return null;
        }
        Pawn.PawnMove();
    }
}
