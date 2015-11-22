using UnityEngine;
using System.Collections;

public class OnePuncher : MonoBehaviour
{
    public Animator anim;
    public bool isPunching = false;

    void Awake()
    {
        anim = this.GetComponent<Animator>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isPunching)
        {
            isPunching = true; // So he doesn't just hold the sword to reflect bullets.
            StartCoroutine(SlashTimeBool());
            anim.SetBool("doPunch", true);
        }

    }

    public IEnumerator SlashTimeBool()
    {
        yield return new WaitForSeconds(0.15f);
        isPunching = false;
        anim.SetBool("doPunch", false);
    }

}
