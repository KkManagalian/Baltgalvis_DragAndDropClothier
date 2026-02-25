using UnityEngine;

public class Animacione : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame

    public void Play()
    {
        animator.SetBool("Pressed", true);
    }
}
