using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using UnityEngine;

namespace WasmScripting;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public class WasmBehaviour : MonoBehaviour {
	private readonly Dictionary<string, MethodInfo> _scriptEvents = new();
	private bool _initialized;

	private void SetupEvents() {
		_initialized = true;
		MethodInfo[] methods = GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

		foreach (MethodInfo method in methods) {
			if (method.CustomAttributes.Any(a => a.AttributeType == typeof(ExternallyVisibleAttribute))) {
				_scriptEvents[method.Name] = method;
			}
		}
	}

	public void TriggerScriptEvent(string eventName) {
		if (!_initialized) SetupEvents();
		if (_scriptEvents.TryGetValue(eventName, out MethodInfo scriptEvent)) {
			scriptEvent.Invoke(this, null);
		}
	}
	
	public void TriggerScriptEvent(string eventName, object arg) {
		if (!_initialized) SetupEvents();
		if (_scriptEvents.TryGetValue(eventName, out MethodInfo scriptEvent)) {
			scriptEvent.Invoke(this, [arg]);
		}
	}
}