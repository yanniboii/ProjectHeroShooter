using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playerCurrency;

    private void OnEnable()
    {
        AbstractEnemy.onEnemyDeath += EarnMoney;
    }

    private void OnDisable()
    {
        AbstractEnemy.onEnemyDeath -= EarnMoney;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Access variables

    public int GetPlayerCurrency() { return playerCurrency; }

    public void SetPlayerCurrency(int playerCurrency) { this.playerCurrency = playerCurrency; }

    public void EarnMoney(int currency) { this.playerCurrency += currency; }

    #endregion
}
