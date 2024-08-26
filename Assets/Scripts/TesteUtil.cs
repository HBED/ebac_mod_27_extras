using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class TesteUtil
{
#if UNITY_EDITOR

    [UnityEditor.MenuItem("Ebac/Test")]

    public static void Test()
    {
        var enemy = GameObject.Find("Enemy");
        var posicao = GameObject.Find("Local");

        Debug.Log("Valores para inimigo");
        Debug.Log(enemy.transform.position);
        Debug.Log(posicao.transform.position);

        EnemyManager.CreatePrefabEnemy(enemy, posicao.transform);
    }


#endif

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

}
