using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject muzzleFlash;

    void Start()
    {
        muzzleFlash.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {
            Shoot();
            StartCoroutine(deactivateMuzzleflash());
        }
	}

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        muzzleFlash.SetActive(true);
    }

    IEnumerator deactivateMuzzleflash()
    {
        if (muzzleFlash.activeSelf)
        {
            yield return new WaitForSeconds(10f);
            muzzleFlash.SetActive(false);
        }
    }

}
