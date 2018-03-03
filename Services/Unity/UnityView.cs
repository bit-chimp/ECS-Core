using btcp.ECS.Services.Interfaces;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace btcp.ECS.Services.Unity
{
	public class UnityView : MonoBehaviour, IView, IPositionListener, IDestroyedListener {

		void IView.Link(IEntity entity, IContext context)
		{
			var e = (GameEntity) entity;
			e.AddPositionListener(this);
			e.AddDestroyedListener(this);

			gameObject.Link(e, context);

			if (e.hasPosition)
			{
				var pos = e.position.value;
				OnPosition(e, pos);
			}
			else
			{
				e.AddPosition(transform.localPosition);
			}
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

	}
}
