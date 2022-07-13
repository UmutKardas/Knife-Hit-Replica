using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawnController : MonoBehaviour
{
    [SerializeField] private Color activeColor;
    [SerializeField] private Color diasbleColor;
    public List<GameObject> knifeObjects = new List<GameObject>();
    public List<GameObject> knifeIcomObjects = new List<GameObject>();

    [SerializeField] private Transform knifeSpawnPointTransform;


    [SerializeField] private GameObject knifePrefab;
    [SerializeField] private int knifeCount;
    [SerializeField] private GameObject knifeIcon;
    [SerializeField] private GameObject lastKnifeIcon;
    public int activeKnifeIndex = 0;
    private int iconListCount = 0;

    void Start()
    {
        GenerateKnifeObjects();
        knifeObjects[activeKnifeIndex].gameObject.SetActive(true);
        lastKnifeIcon = knifeIcon;
        iconListCount = knifeIcomObjects.Count;

    }
    public void IncreaseActiveKnifeIndex(int value)
    {
        activeKnifeIndex += value;
        knifeObjects[activeKnifeIndex].gameObject.SetActive(true);

    }


    void Update()
    {

    }

    private void GenerateKnifeObjects()
    {
        for (int i = 0; i < knifeCount; i++)
        {
            CreateNewKnifeObject();
            CreateKnifeIcon();
        }

    }

    private void CreateNewKnifeObject()
    {
        GameObject newKnife = Instantiate(knifePrefab, knifeSpawnPointTransform.position, Quaternion.identity);
        newKnife.SetActive(false);
        knifeObjects.Add(newKnife);

    }

    public void CreateKnifeIcon()
    {
        GameObject newKnifeIcon = Instantiate(knifeIcon, new Vector3(lastKnifeIcon.transform.position.x, lastKnifeIcon.transform.position.y + 0.4f, lastKnifeIcon.transform.position.z), Quaternion.identity);
        lastKnifeIcon = newKnifeIcon;
        knifeIcomObjects.Add(newKnifeIcon);
        newKnifeIcon.GetComponent<SpriteRenderer>().color = activeColor;

    }

    public void SetKnifeIconDisableColor(int value)
    {
        iconListCount -= value;
        knifeIcomObjects[iconListCount].gameObject.GetComponent<SpriteRenderer>().color = diasbleColor;

    }
}





