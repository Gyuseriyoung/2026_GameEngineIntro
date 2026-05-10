using UnityEngine;
using System.Linq;
using TMPro;
using NUnit.Framework.Interfaces;
public class RankPage : MonoBehaviour
{
    [SerializeField] Transform contentRoot;
    [SerializeField] GameObject rowPrefab;

    StageResultList allData;

    private void Awake()
    {
        allData = StageResultSaver.LoadRank();
        RefreshRankList();
    }
   
    public void RefreshRankList()
    {
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        var sortedData = allData.results.Where(r => r.stage == 1).OrderByDescending(x => x.score).ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            rankText.text = $"{i + 1}. {sortedData[i].playerName} - {sortedData[i].score}";
        }
    }
    public void RefreshRankList2()
    {
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        var sortedData = allData.results.Where(r => r.stage == 2).OrderByDescending(x => x.score).ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            rankText.text = $"{i + 1}. {sortedData[i].playerName} - {sortedData[i].score}";
        }
    }
    public void RefreshRankList3()
    {
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        var sortedData = allData.results.Where(r => r.stage == 3).OrderByDescending(x => x.score).ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefab, contentRoot);
            TMP_Text rankText = row.GetComponentInChildren<TMP_Text>();
            rankText.text = $"{i + 1}. {sortedData[i].playerName} - {sortedData[i].score}";
        }
    }

}
