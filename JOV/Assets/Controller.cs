using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Controller : MonoBehaviour, IDragHandler,IPointerUpHandler,IPointerDownHandler {

	private Image bgImg;
	private Image joystickimg;
	private Vector3 InputVector;

	private void Start()

	{
		bgImg = GetComponent<Image> ();
		joystickimg = transform.GetChild (0).GetComponent<Image> ();

	}
	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
		InputVector = Vector3.zero;
		joystickimg.rectTransform.anchoredPosition = Vector3.zero;
	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgImg.rectTransform, ped.position
			, ped.pressEventCamera, out pos)) 
		{
			pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);
			//Debug.Log (pos);

			InputVector = new Vector3(pos.x*2 + 1,0,pos.y*2 - 1);
			InputVector = (InputVector.magnitude > 1.0f) ?InputVector.normalized:InputVector;
			Debug.Log (InputVector);

			//move joystick

			joystickimg.rectTransform.anchoredPosition =
				new Vector3(InputVector.x * (bgImg.rectTransform.sizeDelta.x/3),
					InputVector.z * (bgImg.rectTransform.sizeDelta.y/3));
		}
	}

	public float Horizontal() {
	
		if (InputVector.x != 0)
			return InputVector.x;
		else
			return Input.GetAxis ("Horizontal");
	}

	public float Vertical() {
		if (InputVector.z != 0)
			return InputVector.z;
		else {
			return Input.GetAxis ("Vertical");
		}

	}


}
