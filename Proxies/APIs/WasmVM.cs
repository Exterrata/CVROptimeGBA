namespace CVR;

public class WasmVM {
	private static readonly Dictionary<string, Action<object[]>> Callbacks = [];
	
	public static WasmVM GetThisVM() => null;
	
	public static WasmVM[] GetAllVMs() => null;

	public static short NetworkId => 0;

	public void SendMessage(string messageId, params object[] parameters) {
		
	}

	public static void SubscribeToMessage(string messageId, Action<object[]> callback) {
		
	}

	public static void UnsubscribeToMessage(string messageId, Action<object[]> callback) {
		
	}
	
	
}