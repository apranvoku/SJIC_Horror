using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnTake : MonoBehaviour
{
    public GameObject Pawn;
    public GameObject Rook;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void PawnMove(){

        StartCoroutine("PawnMoveCoroutine");

    }
    IEnumerator PawnMoveCoroutine()
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
            Debug.Log((PawnFlatPosition - GoalFlatPosition).sqrMagnitude);
            yield return null;
        }
        Rook.GetComponent<PieceSelect>().FirstSquareAchieved = true;
        Rook.layer = 9;
        Rook.transform.GetChild(0).gameObject.layer = 9;
    }
}
