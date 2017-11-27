﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
	private float maxHealth = 50;
	public float currentHealth = 50;
	private float originalScale;
	private GameObject ob;
	private game_manager gm;
	private int diff;
	// Use this for initialization
	void Start () {
		gm = GameObject.Find ("GameManager").GetComponent<game_manager> ();
		originalScale = gameObject.transform.localScale.x;
		if (gm.waves == 1) {
			maxHealth = 100;
		} else if (gm.waves == 2) {
			maxHealth = 150;
		} else if (gm.waves == 3) {
			maxHealth = 250;
		} else if (gm.waves == 4) {
			maxHealth = 300;
		} else if (gm.waves == 5) {
			maxHealth = 350;
			Debug.Log ("SMALL SLIMES?");
			ob = gameObject.transform.parent.gameObject;
			if (ob.name.Equals ("enemy6(Clone)")) {
				Debug.Log ("SMALL SLIMES");
				maxHealth = 100;
			}
		} else if (gm.waves == 6) {
			maxHealth = 350;
		} else if (gm.waves == 7) {
			maxHealth = 400;
		} else if (gm.waves == 8) {
			maxHealth = 300;
		} else if (gm.waves == 9) {
			maxHealth = 450;
		} else if (gm.waves == 10) {
			maxHealth = 500;
		} else if (gm.waves == 11) {
			maxHealth = 550;
		} else if (gm.waves == 12) {
			maxHealth = 600;
		} else if (gm.waves == 13) {
			maxHealth = 650;
		} else if (gm.waves == 14) {
			maxHealth = 700;
		} else if (gm.waves == 15) {
			maxHealth = 1000;
		} else {
			maxHealth = 2000;
		}
		diff = gm.difficulty;
		Debug.Log ("THE DIFF IN MANAGER IS" + diff);
		Debug.Log (diff);
		if (diff == 1) {
			maxHealth = maxHealth / 2;
		} else if (diff == 2) {
			maxHealth = maxHealth;
		} else {
			maxHealth = maxHealth * 2;
		}
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 tmpScale = gameObject.transform.localScale;
		tmpScale.x = currentHealth / maxHealth * originalScale;
		gameObject.transform.localScale = tmpScale;*/
	}

	public void Damage(int dmg) {
		currentHealth -= dmg;
		UpdateHealthUI ();
	}

	public void SetHealth(float health) {
		this.currentHealth = health;
		UpdateHealthUI ();
	}

	public float GetHealth() {
		return this.currentHealth;
	}

	public void UpdateHealthUI() {
		Vector3 tmpScale = gameObject.transform.localScale;
		tmpScale.x = currentHealth / maxHealth * originalScale;
		gameObject.transform.localScale = tmpScale;
	}
}
