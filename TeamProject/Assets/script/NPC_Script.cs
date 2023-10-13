using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Script : MonoBehaviour
{
	public string Question;
	public string PossibleAnswer1;
	public string PossibleAnswer2;
	public string PossibleAnswer3;
	public int CorrectAnswer;

	public GameObject TalkButtonHint;
	public GameLogicScript GameLogicScript;

	private bool _isTalkable;

	private void Start()
	{
		TalkButtonHint.SetActive(false);
	}

	private void Update()
	{
		if (_isTalkable && Input.GetKeyDown(KeyCode.E))
		{
			GameLogicScript.StartDialog(Question,
										new string[]
										{
											PossibleAnswer1,
											PossibleAnswer2,
											PossibleAnswer3,
										},
										CorrectAnswer);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		TalkButtonHint.SetActive(true);
		_isTalkable = true;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		TalkButtonHint.SetActive(false);
		_isTalkable = false;
	}
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Script : MonoBehaviour
{
	public string Question;
	public string PossibleAnswer1;
	public string PossibleAnswer2;
	public string PossibleAnswer3;
	public int CorrectAnswer;

	public GameObject TalkButtonHint;
	public DialogManager GameLogicScript;

	private bool _isTalkable;

	private void Start()
	{
		TalkButtonHint.SetActive(false);
	}

	private void Update()
	{
		if (_isTalkable && Input.GetKeyDown(KeyCode.E))
		{
			GameLogicScript.StartDialog(Question,
										new string[]
										{
											PossibleAnswer1,
											PossibleAnswer2,
											PossibleAnswer3,
										},
										CorrectAnswer);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		TalkButtonHint.SetActive(true);
		_isTalkable = true;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		TalkButtonHint.SetActive(false);
		_isTalkable = false;
	}
}
>>>>>>> main:TeamProject/Assets/NPC_Script.cs
