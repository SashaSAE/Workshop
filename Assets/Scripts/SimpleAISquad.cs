using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAISquad : MonoBehaviour
{
    //handles ai squad movement
    //If the AI is moving as a squad,
    //Set destinations to each squad position
    // Start is called before the first frame update
    [SerializeField] private List<NavMeshAgent> squadMembers;
    [SerializeField] private Transform[] squadPositions;
    void Update()
    {
        //Cycle through all squad members
        //and make them move to squad positions!
        for (int i = 0; i < squadMembers.Count; i++)
        {
            if (squadMembers[i].GetComponent<SimpleAIBrain>().currentTactics == SimpleAIBrain.Tactics.SquadPattern)
            {
                squadMembers[i].SetDestination(squadPositions[i].position);
            }
        }
    }
}
