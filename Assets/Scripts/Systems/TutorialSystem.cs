using Entitas;

public class TutorialSystem : Feature {
    
    public TutorialSystem(Contexts contexts) : base("Tutorial System") {
        Add(new HelloWorldSystem(contexts));
        Add(new DebugMessageSystem(contexts));
    }
}