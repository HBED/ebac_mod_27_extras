using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class EnemyManager : Singleton<EnemyManager>
{
    public Transform position;

    public List<GameObject> listEnemys;

    void Update()   
    {

        var enemy = listEnemys.GetRandom();

        //testando se o random funcionou
        Debug.Log(enemy.transform.position);

    }

    public static void CreatePrefabEnemy(GameObject enemy, Transform posicao)
    {
        var spwanedPiece = Instantiate(enemy, posicao);

        spwanedPiece.transform.position = posicao.position;
    }



}
