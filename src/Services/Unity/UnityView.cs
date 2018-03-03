using btcp.ECS.src.Services.Interfaces;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace btcp.ECS.src.Services.Unity
{
	public class UnityView : MonoBehaviour, IView, IPositionListener, IDestroyedListener, ISpriteListener {

		void IView.Link(IEntity entity, IContext context)
		{
			var e = (GameEntity) entity;
			e.AddPositionListener(this);
			e.AddDestroyedListener(this);
			e.AddSpriteListener(this);

			//Automatically add ECS Components if Unity Component present
			if (e.hasPosition)
			{
				var pos = e.position.value;
				OnPosition(e, pos);
			}
			else
			{
				e.AddPosition(transform.localPosition);
			}

			if (e.hasSprite == false)
			{
				var sr = GetComponent<SpriteRenderer>();
				if (sr)
				{
					e.AddSprite(sr.sprite.name);
				}
			}
			//----------------------------------------
			
			gameObject.Link(e, context);
		}

		public void OnPosition(GameEntity entity, Vector2 value)
		{
			transform.localPosition = value;
		}

		public void OnDestroyed(GameEntity entity)
		{
			
			gameObject.Unlink();
			Destroy(gameObject);
		}

		public void OnSprite(GameEntity entity, string path)
		{
			Debug.Log("On Sprite " + path);
			var sr = gameObject.GetComponent<SpriteRenderer>();
			if (sr == null) sr = gameObject.AddComponent<SpriteRenderer>();
			sr.sprite = Resources.Load<Sprite>(path);
		}
	}
}
