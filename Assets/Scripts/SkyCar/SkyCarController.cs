using UnityEngine;
using UnityEngine.InputSystem;

namespace TestAssignment.SkyCar
{

	public class SkyCarController : MonoBehaviour
	{
		[SerializeField] private WheelCollider[] _wheelColliders = new WheelCollider[4];

		[SerializeField] private float _maxWheelAngle = 30.0f;
		[SerializeField] private float _maxTorque = 300.0f;
		[SerializeField] private float _maxBrakeTorque = 25000.0f;

		private float _angle = 0.0f;
		private float _torque = 0.0f;
		private float _brake = 0.0f;

		private void FixedUpdate()
		{
			_wheelColliders[0].steerAngle = _angle;
			_wheelColliders[1].steerAngle = _angle;

			_wheelColliders[2].motorTorque = _torque;
			_wheelColliders[3].motorTorque = _torque;

			_wheelColliders[2].brakeTorque = _brake;
			_wheelColliders[3].brakeTorque = _brake;
		}

		public void Accelerate(InputAction.CallbackContext callbackContext)
		{
			if (callbackContext.performed || callbackContext.canceled)
			{
				_torque = callbackContext.ReadValue<float>() * _maxTorque;
			}
		}

		public void Brake(InputAction.CallbackContext callbackContext)
		{
			if (callbackContext.performed || callbackContext.canceled)
			{
				_brake = callbackContext.ReadValue<float>() * _maxBrakeTorque;
			}
		}

		public void LeftRight(InputAction.CallbackContext callbackContext)
		{
			if (callbackContext.performed || callbackContext.canceled)
			{
				_angle = callbackContext.ReadValue<float>() * _maxWheelAngle;
			}
		}
	}

}
