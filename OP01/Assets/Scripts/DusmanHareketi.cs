using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DusmanHareketi : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();//değişkenimizi çekip agent üzerinden kontroller yazpabiliriz
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);//SetDestination agent hareket ettirmemizi sağlıyor.player transformuna ulaşacağız yani player nerye giderse düşman onu takip ediyor

    }

}
