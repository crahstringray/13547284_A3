using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMover : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        tweener.AddTween(item.transform, item.transform.position, new Vector3(2.0f, 0.5f, 0.0f), 1.5f);
       
    }
}
