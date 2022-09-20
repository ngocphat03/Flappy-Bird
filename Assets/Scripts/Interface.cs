//Interface for the model factorty
public interface IBirdModelFactory
{
    IBirdModelFactory Model { get; }
}
//Implementation of the model factory
public class BirdModelFactory : IBirdModelFactory
{
    public IBirdModel Model { get; private set;}

    //Tao model
    public BirdModelFactory()
    {
    }
}

//Interface for the view factorty
public interface IBirdViewFactory
{
    IBirdViewFactory View { get; }
}
//Implementation of the view factory
public class BirdViewFactory : IBirdViewFactory
{
    public IBirdView View { get; private set;}

    //Khoi tao view
    public BirdViewFactory()
    {
    }
}
//Interface for the controller factorty
public interface IBirdControllerFactory
{
    IBirdController Controller { get; }
}
//Implementation of the controller factory
public class BirdControllerFactory : IBirdControllerFactory
{
    public IBirdController Controller { get; private set ;}

    //Create just the controller
    public BirdControllerFactory(IBirdModel model, IBirdView view)
    {
        Controller = new BirdController(model, view);
    }
    //Khoi tao controller
    public BirdControllerFactory()
    {
    }
}


 