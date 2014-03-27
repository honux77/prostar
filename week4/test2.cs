using System;

public class Prof {
	public int id;
	public string name;

	public Prof(int id, string name) {
		this.id = id;
		this. name = name;
	}
	public override string ToString() {
		return string.Format("{0}: {1}", id, name);
	}
}

class Test {
	static void Main(string[] args) {
		Prof p = new Prof(1, "호영");
		Console.WriteLine(p);

	}
}
