namespace WasmScripting;

[AttributeUsage(AttributeTargets.Class)]
public class DefaultExecutionOrderAttribute(int order) : Attribute {
	public int Order = order;
}